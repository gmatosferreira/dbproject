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
    public partial class NaoDocenteTurnos : Form
    {
        // Attributes
        private SqlConnection cn;
        private Form previous;
        private NaoDocente nd;
        private int current = 0, counter = 0;
        private List<Bloco> blocos;
        private List<NDFuncao> funcoes;

        // Constructor
        public NaoDocenteTurnos(SqlConnection cn, NaoDocente nd, Form f)
        {
            this.cn = cn;
            this.previous = f;
            this.nd = nd;
            this.blocos = new List<Bloco>();
            this.funcoes = new List<NDFuncao>();
            InitializeComponent();
            // ObjectListView Column groups
            // http://objectlistview.sourceforge.net/python/groupListView.html
            /*this.turno.GroupKeyGetter = delegate (object rowObject) {
                // Group emails by domain (text after @ symbol)
                NDTrabalhaBloco func = (NDTrabalhaBloco)rowObject;
                return "Das " + func.turno.horaInicio.ToString(@"hh", null) + " às " + func.turno.horaFim.ToString(@"hh", null);
            };*/
            // ObjectListView Aditional preferences
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell)
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default
            // Filtering
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses)
        }

        //  Methods

        private void loadBlocos()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Bloco", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bloco t = new Bloco();
                t.coordenadas = reader["coordenadas"].ToString();
                t.nome = reader["nome"].ToString();
                panelFormFieldBloco.Items.Add(t.nome);
                blocos.Add(t);
            }

            // Close reader
            reader.Close();
        }

        private Bloco getBloco(String coord)
        {
            foreach (Bloco b in blocos)
            {
                if (coord.Equals(b.coordenadas, StringComparison.InvariantCultureIgnoreCase))
                    return b;
            }
            return null;
        }

        private Bloco getBlocoByNome(String nome)
        {
            foreach (Bloco b in blocos)
            {
                if (nome.Equals(b.nome, StringComparison.InvariantCultureIgnoreCase))
                    return b;
            }
            return null;
        }

        private void loadFuncoes()
        {
            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.ND_Funcao", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NDFuncao t = new NDFuncao();
                t.codigo= Int32.Parse(reader["codigo"].ToString());
                t.nome = reader["nome"].ToString();
                panelFormFieldFuncao.Items.Add(t.nome);
                funcoes.Add(t);
            }

            // Close reader
            reader.Close();
        }

        private NDFuncao getFuncao(int codigo)
        {
            foreach (NDFuncao f in funcoes)
            {
                if (codigo==f.codigo)
                    return f;
            }
            return null;
        }

        private NDFuncao getFuncao(String nome)
        {
            foreach (NDFuncao f in funcoes)
            {
                if (nome.Equals(f.nome, StringComparison.InvariantCultureIgnoreCase))
                    return f;
            }
            return null;
        }

        private void updateStats()
        {
            // Update interface subtitle with the number of rows being shown
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " registos do funcionário "+nd.nmec.ToString() + "\r\nATENÇÃO! Todas as funções devem ser atribuídas dentro do turno do funcionário, das "+nd.turno.str;
        }

        private void showObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDTrabalhaBloco f = (NDTrabalhaBloco)listObjects.SelectedObjects[0];
            // Set labels values
            panelObjectTitulo.Text = f.turno.str;
            panelObjectSubtitulo.Text = f.bloco.nome + ", como " + f.funcao.nome;
            // Show panel
            if (!panelObject.Visible)
                panelObject.Visible = true;
            panelForm.Visible = false;

        }

        private void editObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDTrabalhaBloco f = (NDTrabalhaBloco)listObjects.SelectedObjects[0];
            // Set textboxes value
            panelFormFieldBloco.Text = f.bloco.nome;
            panelFormFieldFuncao.Text = f.funcao.nome;
            panelFormFieldHoraInicio.Text = f.turno.horaInicio.ToString();
            panelFormFieldHoraFim.Text = f.turno.horaFim.ToString();
            // Set title and description
            panelFormTitulo.Text = "Editar função";
            panelFormDescricao.Text = "Altere os dados e submita o formulário";
            panelFormButton.Text = "Submeter";
            // Block time fields (primary key, not changable)
            panelFormFieldHoraInicio.Enabled = false;
            panelFormFieldHoraFim.Enabled = false;
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
        }

        private void addObject()
        {
            // Clear all fields
            panelFormFieldBloco.SelectedIndex = 0;
            panelFormFieldFuncao.SelectedIndex = 0;
            panelFormFieldHoraInicio.Text = "00:00:00";
            panelFormFieldHoraFim.Text = "00:00:00";
            // Set title and description
            panelFormTitulo.Text = "Adicionar uma nova função";
            panelFormDescricao.Text = "Preencha os dados e submita o formulário";
            panelFormButton.Text = "Criar função";
            // Enable time fields (primary key, not changable)
            panelFormFieldHoraInicio.Enabled = true;
            panelFormFieldHoraFim.Enabled = true;
            // Deselect pre selected row
            listObjects.DeselectAll();
            // Make panel visible
            if (!panelForm.Visible)
                panelForm.Visible = true;
            panelObject.Visible = false;
        }

        private void deleteObject()
        {
            // Get Object
            if (listObjects.Items.Count == 0 | current < 0)
                return;
            NDTrabalhaBloco f = (NDTrabalhaBloco)listObjects.SelectedObjects[0];
            int itemIndex = listObjects.SelectedIndex;
            // Confirm delete
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar esta função?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msgb == DialogResult.No)
                return;
            // Create command 
            String commandText = "DELETE FROM GestaoEscola.ND_trabalha_Bloco WHERE NMec = @NMec AND horaInicio = @HoraInicio";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@NMec", SqlDbType.Int);
            command.Parameters["@NMec"].Value = nd.nmec;
            command.Parameters.Add("@HoraInicio", SqlDbType.Time);
            command.Parameters["@HoraInicio"].Value = nd.turno.horaInicio;
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
                    "Ocorreu um erro, tente novamente!\r\n" + ex.ToString(),  
                    "Erro!",  
                    MessageBoxButtons.OK,  
                    MessageBoxIcon.Error  
                );  
                return;  
            }  
            // If successful query  
            if (rowsAffected==1)  
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
                MessageBox.Show(  
                    "Ocorreu um erro, tente novamente!",  
                    "Erro!",  
                    MessageBoxButtons.OK,  
                    MessageBoxIcon.Error  
                );  
            }   
        }

        private Boolean formValid()
        {            
            // Validate if function ship is inside Nao Docente main ship
            
            Turno novoTurno = new Turno();
            novoTurno.horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text);
            novoTurno.horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text);
            /*
            if (!Turno.isInside(novoTurno, nd.turno))
            {
                MessageBox.Show(
                    "O horário da função deve estar dentro do turno do funcionário!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            */
            // Other time validations 
            if (novoTurno.horaInicio.CompareTo(novoTurno.horaFim) == 0)
            {
                MessageBox.Show(
                    "As horas de início de fim não podem ser iguais!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
            DialogResult userfeedback = DialogResult.Yes;
            if (novoTurno.horaInicio.CompareTo(novoTurno.horaFim) > 0)
            {
                MessageBox.Show(
                    "O horário de início é maior ou igual ao de fim!",
                    "Erro!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
                    return false;
            }
            return true;
        }

        private void submitForm(NDTrabalhaBloco ndtb)
        {
            /* 
             If submition for edit t!=null 
             If new submition t==null 
             */
            bool edit = (ndtb != null);
            // Get form data 
            TimeSpan horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text);
            TimeSpan horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text);
            Bloco bloco = getBlocoByNome(panelFormFieldBloco.Text);
            NDFuncao funcao = getFuncao(panelFormFieldFuncao.Text);
            // Create command 
            String commandText = "INSERT INTO GestaoEscola.ND_trabalha_Bloco VALUES (@BCoordenadas, @NMec, @CodFuncao, @HoraInicio, @HoraFim)";
            if (edit)
                commandText = "UPDATE GestaoEscola.ND_trabalha_Bloco SET Bcoordenadas = @BCoordenadas, codFuncao = @CodFuncao WHERE NMec = @NMec AND horaInicio = @HoraInicio";
            SqlCommand command = new SqlCommand(commandText, cn);
            // Add vars 
            command.Parameters.Add("@BCoordenadas", SqlDbType.VarChar);
            command.Parameters["@BCoordenadas"].Value = bloco.coordenadas.Trim();
            MessageBox.Show(bloco.coordenadas.Trim());
            command.Parameters.Add("@NMec", SqlDbType.Int);
            command.Parameters["@NMec"].Value = nd.nmec;
            command.Parameters.Add("@CodFuncao", SqlDbType.Int);
            command.Parameters["@CodFuncao"].Value = funcao.codigo;
            command.Parameters.Add("@HoraInicio", SqlDbType.Time);
            command.Parameters["@HoraInicio"].Value = horaInicio;
            if (!edit)
            {
                command.Parameters.Add("@HoraFim", SqlDbType.Time);
                command.Parameters["@HoraFim"].Value = horaFim;
            }
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
                    if (ex.Errors[i].Message.IndexOf("A hora de início deve ser menor que a de fim", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = ex.Errors[i].Message;
                        break;
                    }
                    else if (ex.Errors[i].Message.IndexOf("O horário da nova função deve estar dentro do turno principal do funcionário", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = ex.Errors[i].Message;
                        break;
                    }
                    else if (ex.Errors[i].Message.IndexOf("O horário da nova função colide com o horário de outra função já atribuída", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        errorMessage = ex.Errors[i].Message;
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
            if (rowsAffected == 2)
            {
                // If add operation 
                if (!edit)
                {
                    // Add tuple to interface list 
                    ndtb = new NDTrabalhaBloco();
                    ndtb.bloco = bloco;
                    ndtb.nd = nd;
                    ndtb.funcao = funcao;
                    ndtb.turno = new Turno();
                    ndtb.turno.horaInicio = horaInicio;
                    ndtb.turno.horaFim = horaFim;
                    listObjects.AddObject(ndtb);
                }
                else
                {
                    // Get object on interface list and change attributes 
                    ndtb.funcao = funcao;
                    ndtb.turno.horaInicio = horaInicio;
                    ndtb.turno.horaFim = horaFim;
                }
                // SHow feedback to user 
                String successMessage = "A função foi adicionada com sucesso ao funcionário!";
                if (edit)
                    successMessage = "A função foi editada com sucesso no funcionário";
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
            // Get turnos
            loadBlocos();
            loadFuncoes();

            // Execute SQL query to get Docente rows
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.ND_trabalha_Bloco WHERE NMec="+nd.nmec.ToString(), cn);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list of Objects given the query results
            List<NDTrabalhaBloco> tuplos = new List<NDTrabalhaBloco>();
            while (reader.Read())
            {
                NDTrabalhaBloco d = new NDTrabalhaBloco();
                d.nd = nd;
                d.funcao = getFuncao(Int32.Parse(reader["codFuncao"].ToString()));
                d.bloco = getBloco(reader["Bcoordenadas"].ToString());
                Turno t = new Turno();
                t.horaInicio = TimeSpan.Parse(reader["horaInicio"].ToString());
                t.horaFim = TimeSpan.Parse(reader["horaFim"].ToString());
                d.turno = t;
                tuplos.Add(d);
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

        private void panelFormButton_Click(object sender, EventArgs e)
        {
            // Execute operation 
            if (formValid())
            {
                // Edit 
                if (listObjects.SelectedIndex >= 0)
                {
                    submitForm((NDTrabalhaBloco)listObjects.SelectedObjects[0]);
                }
                // Add new  
                else
                {
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
