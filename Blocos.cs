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
using System.Diagnostics; 
 
namespace Funcionarios 
{ 
    public partial class Blocos : Form 
    { 
        // Attributes 
        private SqlConnection cn; 
        private Form previous; 
        private int current = 0, counter = 0, lastId = 0;
        private List<NaoDocente> naodocentes;
        private List<BlocoTipo> tiposbloco;

        // Constructor 
        public Blocos(SqlConnection cn, Form f) 
        { 
            this.cn = cn; 
            this.previous = f;
            this.naodocentes = new List<NaoDocente>();
            this.tiposbloco = new List<BlocoTipo>();
            InitializeComponent();
            // ObjectListView Column groups 
            // http://objectlistview.sourceforge.net/python/groupListView.html 
            this.nome.GroupKeyGetter = delegate (object rowObject)
            {
                return "Nome";
            };
            this.coordenadas.GroupKeyGetter = delegate (object rowObject)
            {
                return "Coordenadas";
            };
            // ObjectListView Aditional preferences 
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell) 
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default 
            // Filtering 
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses) 
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
                panelFormFieldSupervisor.Items.Add(d.ToString());
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

        private void loadBlocosTipo()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.BlocoTipo", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BlocoTipo t = new BlocoTipo();
                t.codigo = Int32.Parse(reader["codigo"].ToString());
                t.nome = reader["nome"].ToString();
                panelFormFieldTipo.Items.Add(t.nome);
                tiposbloco.Add(t);
            }

            // Close reader
            reader.Close();
        }

        private BlocoTipo getBlocoTipo(int codigo)
        {
            foreach (BlocoTipo t in tiposbloco)
            {
                if (codigo == t.codigo)
                    return t;
            }
            return null;
        }

        private BlocoTipo getBlocoTipo(String nome)
        {
            foreach (BlocoTipo t in tiposbloco)
            {
                if (nome.Equals(t.nome, StringComparison.InvariantCultureIgnoreCase))
                    return t;
            }
            return null;
        }

        private void updateStats() 
        { 
            // Update interface subtitle with the number of rows being shown 
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " blocos"; 
        } 
 
        private void showObject() 
        { 
            // Get Object 
            if (listObjects.Items.Count == 0 | current < 0) 
                return; 
            Bloco f = (Bloco)listObjects.SelectedObjects[0]; 
            // Set labels values 
            panelObjectTitulo.Text = f.nome; 
            panelObjectSubtitulo.Text = f.coordenadas; 
            // Show panel 
            if (!panelObject.Visible) 
                panelObject.Visible = true; 
            // Hide form 
            if (panelForm.Visible) 
                panelForm.Visible = false; 
 
        } 
 
        private void editObject() 
        { 
            // Get Object 
            if (listObjects.Items.Count == 0 | current < 0) 
                return; 
            Bloco f = (Bloco)listObjects.SelectedObjects[0];
            // Set textboxes value 
            panelFormFieldCoordenadas.Text = f.coordenadas;
            panelFormFieldNome.Text = f.nome;
            panelFormFieldTipo.Text = f.tipo.nome;
            panelFormFieldSupervisor.Text = f.supervisor.ToString();
            // Set title and description 
            panelFormTitulo.Text = "Editar bloco"; 
            panelFormDescricao.Text = "Altere os dados e submita o formulário"; 
            panelFormButton.Text = "Submeter";
            // Block primary keys
            panelFormFieldCoordenadas.Enabled = false;
            // Make panel visible 
            if (!panelForm.Visible) 
                panelForm.Visible = true; 
        } 
 
        private void addObject() 
        { 
            // Deselect row selected 
            listObjects.SelectedItems.Clear();
            // Clear all fields 
            panelFormFieldCoordenadas.Text = "";
            panelFormFieldNome.Text = "";
            panelFormFieldTipo.SelectedIndex=0;
            panelFormFieldSupervisor.SelectedIndex=0;
            // Set title and description 
            panelFormTitulo.Text = "Adicionar um novo turno"; 
            panelFormDescricao.Text = "Preencha os dados e submita o formulário"; 
            panelFormButton.Text = "Criar turno";
            // Deselect pre selected row
            listObjects.DeselectAll();
            // Allow primary keys
            panelFormFieldCoordenadas.Enabled = true;
            // Make form panel visible 
            if (!panelForm.Visible) 
                panelForm.Visible = true; 
            // Hide object selected panel 
            if (panelObject.Visible) 
                panelObject.Visible = false; 
        } 
 
        private void deleteObject() 
        { 
            // Get Object 
            if (listObjects.Items.Count == 0 | current < 0) 
                return; 
            Bloco f = (Bloco)listObjects.SelectedObjects[0]; 
            int itemIndex = listObjects.SelectedIndex; 
            // Confirm delete 
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar este bloco ("+f.nome+", "+f.coordenadas+")?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); 
            if (msgb == DialogResult.No) 
                return;
            // Create command 
            String commandText = "pr_BlocosDELETE";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@Coordenadas", SqlDbType.VarChar);
            command.Parameters["@Coordenadas"].Value = f.coordenadas;
            command.Parameters.Add("@Feedback", SqlDbType.VarChar, 4000).Direction=ParameterDirection.Output;
            // Return value stuff
            command.Parameters.Add("@ReturnVal", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            // Execute query 
            int rowsAffected = 0;
            int returnValue;
            String returnMessage = "";
            try 
            { 
                rowsAffected = command.ExecuteNonQuery();
                returnValue = (int)command.Parameters["@ReturnVal"].Value;
                returnMessage = (String)command.Parameters["@Feedback"].Value;
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected));
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.GetType().ToString());
                MessageBox.Show( 
                    "Ocorreu um erro, tente novamente!\r\n\r\n" + ex.ToString(), 
                    "Erro!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error 
                ); 
                return; 
            }
            // If successful query 
            if (rowsAffected==1 && returnValue==1) 
            { 
                // Remove object from interface list 
                listObjects.Items.RemoveAt(itemIndex); 
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
                panelForm.Visible = false;
                panelObject.Visible = false;
            }
            else 
            {
                String errorMessage = "Ocorreu um erro, tente novamente!";
                if (returnMessage.Contains("conflicted with the REFERENCE constraint \"FK"))
                    errorMessage = "Este bloco não pode ser eliminado enquanto estiver atribuído a um docente ou a uma sala!";
                MessageBox.Show( 
                    errorMessage + "\r\n\r\n" + returnMessage, 
                    "Erro!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error 
                ); 
            }  
        } 
 
        private Boolean formValid() 
        {
            // Check if specific fields are valid
            bool error = false;
            StringBuilder sb = new StringBuilder();
            if (!RegexExpressions.isCoordinates(panelFormFieldCoordenadas.Text) || panelFormFieldCoordenadas.Text.Length>40)
            {
                error = true;
                sb.Append(" Coordenadas (max 40 caracteres)");
            }
            // Check others
            if (panelFormFieldNome.Text == "" || panelFormFieldNome.Text.Length > 15)
            {
                error = true;
                sb.Append(" Nome (max 15 caracteres)");
            }
            // Give user feedback
            if (error)
            {
                MessageBox.Show(
                   "Confirme que preencheu corretamente os seguintes campos:" + sb.ToString(),
                   "Erro na submissão!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            return !error;
        } 
 
        private void submitForm(Bloco bloco) 
        { 
            /* 
             If submition for edit t!=null 
             If new submition t==null 
             */ 
            bool edit = (bloco != null);
            // Get form data 
            String nome = panelFormFieldNome.Text;
            String coordenadas = panelFormFieldCoordenadas.Text;
            BlocoTipo blocotipo = getBlocoTipo(panelFormFieldTipo.Text);
            NaoDocente supervisor = getNaoDocente(panelFormFieldSupervisor.Text);
            // Create command 
            String commandText = "INSERT INTO GestaoEscola.Bloco VALUES (@Coordenadas, @Nome, @Tipo, @Supervisor)"; 
            if (edit) 
                commandText = "UPDATE GestaoEscola.Bloco SET nome = @Nome, tipo = @Tipo, supervisor = @Supervisor WHERE coordenadas = @Coordenadas"; 
            SqlCommand command = new SqlCommand(commandText, cn); 
            // Add vars 
            command.Parameters.Add("@Coordenadas", SqlDbType.VarChar).Value=coordenadas;
            command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@Tipo", SqlDbType.Int).Value = blocotipo.codigo;
            command.Parameters.Add("@Supervisor", SqlDbType.Int).Value = supervisor.nmec;
            // Execute query 
            int rowsAffected = 0;
            try
            { 
                rowsAffected = command.ExecuteNonQuery(); 
                Console.WriteLine(String.Format("rowsAffected {0}", rowsAffected)); 
            } 
            catch (SqlException ex) 
            {
                String errorMessage = "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!";
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    if (ex.Errors[i].Message.IndexOf("Violation of PRIMARY KEY constraint", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = "Não pode inserir um bloco nas coordenadas de um já existente!";
                        break;
                    }

                }
                MessageBox.Show( 
                    errorMessage+"\r\n\r\n" + ex.ToString(), 
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
                    // Update lastId  
                    lastId++; 
                    // Add tuple to interface list 
                    bloco = new Bloco();
                    bloco.coordenadas = coordenadas;
                    bloco.nome = nome;
                    bloco.tipo = blocotipo;
                    bloco.supervisor = supervisor;
                    listObjects.AddObject(bloco); 
                } else 
                {
                    // Get object on interface list and change attributes 
                    bloco.nome = nome;
                    bloco.tipo = blocotipo;
                    bloco.supervisor = supervisor;
                } 
                // SHow feedback to user 
                String successMessage = "O bloco foi adicionado com sucesso!"; 
                if (edit) 
                    successMessage = "O bloco foi atualizado com sucesso";
                MessageBox.Show( 
                    successMessage, 
                    "Sucesso!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information 
                );
                // Update objects displayed on interface 
                listObjects.BuildList(true);
                // Update stats
                updateStats();
                // Hide panels 
                panelForm.Visible = false;
                panelObject.Visible = false;
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
        private void FormClosed_Handler(object sender, FormClosedEventArgs e) 
        { 
            // When form closed, show the previous one (main interface form) 
            previous.Show(); 
        } 
 
 
        private void FormLoad_Handler(object sender, EventArgs e) 
        {
            // Load stuff
            loadBlocosTipo();
            loadNaoDocentes();

            // Execute SQL query to get Docente rows 
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Bloco", cn); 
            SqlDataReader reader = cmd.ExecuteReader(); 
            // Create list of Objects given the query results 
            List<Bloco> tuplos = new List<Bloco>(); 
            while (reader.Read()) 
            { 
                Bloco t = new Bloco();
                t.coordenadas = reader["coordenadas"].ToString();
                t.nome = reader["nome"].ToString();
                t.tipo = getBlocoTipo(Int32.Parse(reader["tipo"].ToString()));
                t.supervisor = getNaoDocente(Int32.Parse(reader["supervisor"].ToString()));
                tuplos.Add(t); 
                counter++; 
            } 
 
            // Close reader 
            reader.Close(); 
 
            // ObjectListView 
            // Add Objects to list view 
            listObjects.SetObjects(tuplos); 
 
            // Update stats 
            updateStats(); 
        } 
 
        private void panelObjectEsconder_Click(object sender, EventArgs e) 
        { 
            // Hide data panel (both edit and data) 
            panelObject.Visible = false; 
            panelForm.Visible = false; 
        } 
 
        private void panelObjectEditar_Click(object sender, EventArgs e) 
        { 
            // Edit object btn 
            if (listObjects.SelectedIndex >= 0) 
            { 
                editObject(); 
            } 
        } 
 
        private void buttonAdicionarObject_Click(object sender, EventArgs e) 
        { 
            // Add object btn 
            addObject(); 
        } 
 
        private void panelFormHide_Click(object sender, EventArgs e) 
        { 
            // Hide pannel 
            panelForm.Visible = false; 
        } 
 
        private void panelObjectEliminar_Click(object sender, EventArgs e) 
        { 
            // Delete Object btn 
            if (listObjects.SelectedIndex >= 0) 
            { 
                deleteObject(); 
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            Bloco b1 = (Bloco)listObjects.SelectedObjects[0];

            //this.Hide();
            BlocoSalas f = new BlocoSalas(this,cn, b1);
            f.ShowDialog();
        }

        private void panelFormButton_Click(object sender, EventArgs e) 
        {             
            // Execute operation 
            if (formValid()) 
            { 
                // Edit 
                if (listObjects.SelectedIndex >= 0) 
                { 
                    submitForm((Bloco)listObjects.SelectedObjects[0]); 
                } 
                // Add new  
                else{ 
                    submitForm(null); 
                } 
            } 
        } 
 
        private void funcionariosListView_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            // When new row selected, show it's Object data 
            if (listObjects.SelectedIndex >= 0) 
            { 
                showObject(); 
            } 
        } 
    } 
} 
