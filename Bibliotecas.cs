using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using BrightIdeasSoftware;
using BrightIdeasSoftware;
using System.Diagnostics.Eventing.Reader;

namespace Funcionarios
{
    public partial class Bibliotecas : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private int current = 0, counter = 0;
        private List<NaoDocente> naodocentes;
        private List<Biblioteca> bibliotecas;
        private Biblioteca bibliotecaAtual;


        // Constructor
        public Bibliotecas(SqlConnection cn, Form f)
        {
            this.cn = cn;
            this.previous = f;
            this.naodocentes = new List<NaoDocente>();
            this.bibliotecas = new List<Biblioteca>();
            this.bibliotecaAtual = null;
            InitializeComponent();
            // ObjectListView Column groups
            // http://objectlistview.sourceforge.net/python/groupListView.html
            this.catalogoIDInterno.GroupKeyGetter = delegate (object rowObject) {
                // When the same is returned by every object, all of them are put together in one group
                return "ID Interno";
            };
            this.catalogoISBN.GroupKeyGetter = delegate (object rowObject)
            {
                return "ISBN";
            };
            this.catalogoTitulo.GroupKeyGetter = delegate (object rowObject)
            {
                return "Título";
            };
            // ObjectListView Aditional preferences
            this.listCatalogo.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listCatalogo.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            pesquisaCatalogoSelect.SelectedIndex = 0; // Set atribute combo box selected index to xero as default
            this.listCatalogo.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        //  Methods

        private void loadNaoDocentes()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_NaoDocentes", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NaoDocente d = new NaoDocente();
                d.nmec = Int32.Parse(reader["NMec"].ToString());
                d.nome = reader["nome"].ToString();
                //panelFormFieldSupervisor.Items.Add(d.ToString());
                naodocentes.Add(d);
                counter++;
            }

            // Close reader
            reader.Close();
        }

        private NaoDocente getNaoDocente(int nmec)
        {
            foreach (NaoDocente t in naodocentes)
            {
                if (nmec == t.nmec)
                    return t;
            }
            return null;
        }

        private NaoDocente getNaoDocente(String str)
        {
            foreach (NaoDocente t in naodocentes)
            {
                if (str.Equals(t.ToString(), StringComparison.InvariantCultureIgnoreCase))
                    return t;
            }
            return null;
        }

        private void loadBibliotecas()
        {
            // Execute SQL query
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Biblioteca;", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Biblioteca b = new Biblioteca();
                b.horario = new Turno();
                b.horario.horaInicio = TimeSpan.Parse(reader["horaAbertura"].ToString());
                b.horario.horaFim = TimeSpan.Parse(reader["horaEncerramento"].ToString());
                b.supervisor = getNaoDocente(Int32.Parse(reader["supervisor"].ToString()));
                b.nome = reader["nome"].ToString();
                escolhaBiblioteca.Items.Add(b.nome);
                bibliotecas.Add(b);
            }
            reader.Close();

        }

        private Biblioteca getBiblioteca(String nome)
        {
            foreach (Biblioteca b in bibliotecas)
            {
                if (nome.Equals(b.nome, StringComparison.InvariantCultureIgnoreCase))
                    return b;
            }
            return null;
        }

        private void changeBibliotecaContext(Biblioteca b)
        {
            if (b == null)
                return;

            bibliotecaAtual = b;

            // Clear all data showed
            listCatalogo.Items.Clear();

            // Muda todo o contexto da interface para os dados da biblioteca passada como argumento
            janelaSubtitulo.Text = b.nome;

            // Get Catálogo
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_LivrosComEstadoCompletos WHERE biblioteca = @Biblioteca", cn);
            cmd.Parameters.Add("@Biblioteca", SqlDbType.VarChar).Value = b.nome;
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<Livro> livros = new List<Livro>();
            while (reader.Read())
            {
                Livro l = new Livro();
                l.ISBN= reader["ISBN"].ToString();
                l.titulo = reader["titulo"].ToString();
                l.autores = reader["autores"].ToString();
                l.editora = reader["editora"].ToString();
                l.anoedicao = Int32.Parse(reader["anoEdicao"].ToString());
                l.idinterno = Int32.Parse(reader["IDInterno"].ToString());
                if (Int32.Parse(reader["estado"].ToString()) == 0)
                    l.estado = LivroEstado.DISPONÍVEL;
                else
                    l.estado = LivroEstado.EMPRESTADO;
                livros.Add(l);
            }

            // Make elements visible
            catalogoTitle.Visible = true;
            buttonAdicionarObjectCatalogo.Visible = true;
            pesquisaCatalogoLabel.Visible = true;
            pesquisaCatalogoSelect.Visible = true;
            pesquisaCatalogoTexto.Visible = true;
            listCatalogo.Visible = true;


            // ObjectListView
            // Add Objects to list view
            listCatalogo.SetObjects(livros);

            // Close reader
            reader.Close();
        }

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            //janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " registos";
        }

        // Catalogo
        private void showObjectCatalogo()
        {
            // Get Object
            if (listCatalogo.Items.Count == 0 | current < 0)
                return;
            Livro f = (Livro)listCatalogo.SelectedObjects[0];
            // Set labels values
            panelObjectCatalogoTitulo.Text = f.titulo;
            panelObjectCatalogoSubtitulo.Text = f.ISBN;
            // Show panel
            if (!panelObjectCatalogo.Visible)
                panelObjectCatalogo.Visible = true;
            panelFormCatalogo.Visible = false;

        }

        private void editObjectCatalogo()
        {
            // Get Object
            if (listCatalogo.Items.Count == 0 | current < 0)
                return;
            Livro f = (Livro)listCatalogo.SelectedObjects[0];
            // Set textboxes value
            panelFormCatalogoFieldISBN.Text = f.ISBN;
            panelFormCatalogoFieldEditora.Text = f.editora;
            panelFormCatalogoFieldAnoEdicao.Text = f.anoedicao.ToString();
            panelFormCatalogoFieldTitulo.Text = f.titulo;
            panelFormCatalogoFieldAutores.Text = f.autores;
            // Disable fields not changable
            panelFormCatalogoFieldISBN.Enabled = false;
            // Set title and description
            panelFormCatalogoTitulo.Text = "Editar livro " + f.ISBN;
            panelFormCatalogoSubtitulo.Text = "Altere os dados e submita o formulário";
            panelFormCatalogoBotaoSubmeter.Text = "Submeter";
            // Make form visible
            panelFormCatalogo.Visible = true;
        }

        private void addObjectCatalogo()
        {
            // Clear all fields
            panelFormCatalogoFieldISBN.Text = "";
            panelFormCatalogoFieldEditora.Text = "";
            panelFormCatalogoFieldAnoEdicao.Text = "";
            panelFormCatalogoFieldTitulo.Text = "";
            panelFormCatalogoFieldAutores.Text = "";
            // Enable fields that are not editable
            panelFormCatalogoFieldISBN.Enabled = true;
            // Set title and description
            panelFormCatalogoTitulo.Text = "Adicionar um novo livro";
            panelFormCatalogoSubtitulo.Text = "Preencha os dados e submita o formulário";
            panelFormCatalogoBotaoSubmeter.Text = "Criar livro";
            // Deselect pre selected row
            listCatalogo.DeselectAll();
            // Make panel visible
            panelFormCatalogo.Visible = true;
            panelObjectCatalogo.Visible = false;
        }

        private void pesquisarCatalogo()
        {
            // Get attribute and value fields text
            String atr = pesquisaCatalogoSelect.Text;
            String val = pesquisaCatalogoTexto.Text;
            if (atr=="" || val=="")
            {
                // If one of them is empty, don't filter
                this.listCatalogo.ModelFilter = null;
            } else
            {
                // Define filtering
                this.listCatalogo.ModelFilter = new ModelFilter(delegate (object x) {
                    Livro func = (Livro)x;
                    String toFilter = "";
                    switch(atr)
                    {
                        case "ISBN":
                            toFilter = func.ISBN.ToString();
                            break;
                        case "Estado":
                            toFilter = func.estado.ToString();
                            break;
                        case "Título":
                            toFilter = func.titulo;
                            break;
                        case "Ano edição":
                            toFilter = func.anoedicao.ToString();
                            break;
                        case "Editora":
                            toFilter = func.editora;
                            break;
                        case "Autores":
                            toFilter = func.autores;
                            break;
                    }
                    if (toFilter.ToLower().Contains(val.ToLower()))
                        return true;
                    return false;
                });
            }
            // Hide data panel (both edit and data)
            panelObjectCatalogo.Visible = false;
            panelFormCatalogo.Visible = false;
        }

        private void deleteObjectCatalogo()
        {
            // Get Object
            if (listCatalogo.Items.Count == 0 | current < 0)
                return;
            Livro f = (Livro)listCatalogo.SelectedObjects[0];
            int itemIndex = listCatalogo.SelectedIndex;
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar o livro " + f.titulo + " ("+ f.ISBN + ", ID "+ f.idinterno.ToString()+")?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            // Delete tuple on db 
            String commandText = "DELETE FROM GestaoEscola.Livro WHERE ISBN = @ISBN AND biblioteca = @Biblioteca AND IDInterno = @ID";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = f.ISBN;
            command.Parameters.Add("@Biblioteca", SqlDbType.VarChar).Value = bibliotecaAtual.nome;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = f.idinterno;

            // Execute query 
            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro, tente novamente!\r\n\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If successful query 
            if (rowsAffected == 1)
            {
                // Remove object from interface list 
                listCatalogo.Items.RemoveAt(itemIndex);
                // Show user feedback 
                MessageBox.Show(
                    "O tuplo foi eliminado com sucesso da base de dados!",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Update stats
                updateStats();
                // Hide panels 
                panelFormCatalogo.Visible = false;
                panelObjectCatalogo.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "Ocorreu um erro, tente novamente!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Boolean formValidCatalogo()
        {
            // Check if specific fields are valid
            bool error = false;
            StringBuilder sb= new StringBuilder();
            if (!RegexExpressions.isISBN(panelFormCatalogoFieldISBN.Text))
            {
                error = true;
                sb.Append(" ISBN");
            }
            if (!RegexExpressions.isInteger(panelFormCatalogoFieldAnoEdicao.Text))
            {
                error = true;
                sb.Append(" Ano Edicao (deve ser inteiro!)");
            }
            // Check others
            if (panelFormCatalogoFieldEditora.Text=="" || panelFormCatalogoFieldEditora.Text.Length>30)
            {
                error = true;
                sb.Append(" Editora (max 30 caracteres)");
            }
            if (panelFormCatalogoFieldTitulo.Text == "" || panelFormCatalogoFieldTitulo.Text.Length > 40)
            {
                error = true;
                sb.Append(" Título (max 40 caracteres)");
            }
            // Give user feedback
            if (error)
            {
                MessageBox.Show(
                   "Confirme que preencheu corretamente os seguintes campos:"+sb.ToString(),
                   "Atenção!",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Exclamation
               );
            }
            return !error;
        }

        public int getNextIDLivro(String ISBN)
        {
            int id = 1;
            foreach(Object obj in listCatalogo.Objects)
            {
                Livro l = (Livro)obj;
                if (l.ISBN.Equals(ISBN.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    if (l.idinterno >= id)
                        id = l.idinterno + 1;
                }
            }
            return id;
        }

        private void submitFormCatalogo(Livro livro)
        {
            bool edit = (livro != null);

            // Get form data 
            String ISBN = panelFormCatalogoFieldISBN.Text;
            String titulo = panelFormCatalogoFieldTitulo.Text;
            String autores = panelFormCatalogoFieldAutores.Text;
            String editora = panelFormCatalogoFieldEditora.Text;
            int anoEdicao = Int32.Parse(panelFormCatalogoFieldAnoEdicao.Text);
            int idinterno = getNextIDLivro(ISBN);

            // Create command 
            String commandText = "INSERT INTO GestaoEscola.Livro VALUES (@ISBN,@Biblioteca,@ID,@Titulo,@Autores,@AnoEdicao,@Editora)";
            if (edit)
                commandText = "UPDATE GestaoEscola.Livro SET titulo = @Titulo, autores = @Autores, anoEdicao = @AnoEdicao, editora = @Editora WHERE ISBN = @ISBN AND biblioteca = @Biblioteca AND IDInterno = @ID";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = ISBN;
            command.Parameters.Add("@Biblioteca", SqlDbType.VarChar).Value = bibliotecaAtual.nome;
            command.Parameters.Add("@ID", SqlDbType.Int);
            if (edit)
                command.Parameters["@ID"].Value = livro.idinterno;
            else
                command.Parameters["@ID"].Value = idinterno;
            command.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = titulo;
            command.Parameters.Add("@Autores", SqlDbType.Text).Value = autores;
            command.Parameters.Add("@AnoEdicao", SqlDbType.Int).Value = anoEdicao;
            command.Parameters.Add("@Editora", SqlDbType.VarChar).Value = editora;
            // Execute query 
            int rowsAffected = 0;
            try
            {
                rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!\r\n\r\n" + ex.ToString(),
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            // If query is successful 
            if (rowsAffected == 1)
            {
                // If add operation 
                if (!edit)
                {
                    // Add tuple to interface list 
                    livro = new Livro();
                    livro.ISBN = ISBN;
                    livro.titulo = titulo;
                    livro.autores = autores;
                    livro.editora = editora;
                    livro.anoedicao = anoEdicao;
                    livro.idinterno = idinterno;
                    livro.estado = LivroEstado.DISPONÍVEL;
                    listCatalogo.AddObject(livro);
                }
                else
                {
                    // Get object on interface list and change attributes 
                    livro.titulo = titulo;
                    livro.autores = autores;
                    livro.editora = editora;
                    livro.anoedicao = anoEdicao;
                    livro.idinterno = idinterno;
                }
                // SHow feedback to user 
                String successMessage = "O livro foi adicionado com sucesso!";
                if (edit)
                    successMessage = "O livro foi editado com sucesso";
                MessageBox.Show(
                    successMessage,
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Update objects displayed on interface 
                listCatalogo.BuildList(true);
                // Hide panels 
                panelFormCatalogo.Visible = false;
                panelObjectCatalogo.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Event handlers
        private void Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When form closed, show the previous one (main interface form)
            previous.Show();
        }


        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // Load grupos disciplinares
            loadNaoDocentes();
            loadBibliotecas();


        }

        private void listCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeBibliotecaContext(getBiblioteca(escolhaBiblioteca.Text));
        }

        private void panelObjectCatalogoEsconder_Click(object sender, EventArgs e)
        {
            // Hide data panel (both edit and data)
            panelObjectCatalogo.Visible = false;
            panelFormCatalogo.Visible = false;
        }

        // Catalogo
        private void pesquisaCatalogoTexto_TextChanged(object sender, EventArgs e)
        {
            // When textbox value changes, compute new search
            pesquisarCatalogo();
        }

        private void pesquisaCatalogoAtributo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When attr combobox value changes, compute new search
            pesquisarCatalogo();
        }

        //TODO change
        private void funcionariosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When new row selected, show it's Object data
            if (listCatalogo.SelectedIndex >= 0)
            {
                showObjectCatalogo();
            }
        }
        private void panelObjectCatalogoEditar_Click(object sender, EventArgs e)
        {
            // Edit object btn
            if (listCatalogo.SelectedIndex >= 0)
            {
                editObjectCatalogo();
            }
        }

        private void panelObjectCatalogoAdicionar_Click(object sender, EventArgs e)
        {
            // Add object btn
            addObjectCatalogo();
        }

        private void panelFormCatalogoHide_Click(object sender, EventArgs e)
        {
            // Hide pannel
            panelFormCatalogo.Visible = false;
        }

        private void panelObjectCatalogoEliminar_Click(object sender, EventArgs e)
        {
            // Delete Object btn
            if (listCatalogo.SelectedIndex >= 0)
            {
                deleteObjectCatalogo();
            }
        }

        private void panelFormCatalogoSubmit_Click(object sender, EventArgs e)
        {
            if (formValidCatalogo())
            {
                // Edit 
                if (listCatalogo.SelectedIndex >= 0)
                {
                    submitFormCatalogo((Livro)listCatalogo.SelectedObjects[0]);
                }
                // Add new  
                else
                {
                    submitFormCatalogo(null);
                }
            }
        }

    }
}
