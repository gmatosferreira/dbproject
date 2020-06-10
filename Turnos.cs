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
    public partial class Turnos : Form 
    { 
        // Attributes 
        private SqlConnection cn; 
        private Form previous; 
        private int current = 0, counter = 0, lastId = 0; 
 
        // Constructor 
        public Turnos(SqlConnection cn, Form f) 
        { 
            this.cn = cn; 
            this.previous = f; 
            InitializeComponent(); 
            // ObjectListView Column groups 
            // http://objectlistview.sourceforge.net/python/groupListView.html 
            // ObjectListView Aditional preferences 
            this.listObjects.FullRowSelect = true; //Make selection select the full row (and not only a cell) 
            this.listObjects.SelectedIndex = 0; //Make the first row selected ad default 
            // Filtering 
            this.listObjects.UseFiltering = true; // Activate filtering (for search porpuses) 
        } 
 
        //  Methods 
 
        private void updateStats() 
        { 
            // Update interface subtitle with the number of rows being shown 
            janelaSubtitulo.Text = "A mostrar " + listObjects.Items.Count.ToString() + " turnos"; 
        } 
 
        private void showObject() 
        { 
            // Get Object 
            if (listObjects.Items.Count == 0 | current < 0) 
                return; 
            Turno f = (Turno)listObjects.SelectedObjects[0]; 
            // Set labels values 
            panelObjectTitulo.Text = "Turno"; 
            panelObjectSubtitulo.Text = f.str; 
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
            Turno f = (Turno)listObjects.SelectedObjects[0]; 
            // Set textboxes value 
            panelFormFieldHoraInicio.Text = f.horaInicio.ToString(); 
            panelFormFieldHoraFim.Text = f.horaFim.ToString(); 
            // Set title and description 
            panelFormTitulo.Text = "Editar turno"; 
            panelFormDescricao.Text = "Altere os dados e submita o formulário"; 
            panelFormButton.Text = "Submeter"; 
            // Make panel visible 
            if (!panelForm.Visible) 
                panelForm.Visible = true; 
        } 
 
        private void addObject() 
        { 
            // Deselect row selected 
            listObjects.SelectedItems.Clear(); 
            // Clear all fields 
            panelFormFieldHoraInicio.Text = "00:00:00"; 
            panelFormFieldHoraFim.Text = "00:00:00"; 
            // Set title and description 
            panelFormTitulo.Text = "Adicionar um novo turno"; 
            panelFormDescricao.Text = "Preencha os dados e submita o formulário"; 
            panelFormButton.Text = "Criar turno";
            // Deselect pre selected row
            listObjects.DeselectAll();
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
            Turno f = (Turno)listObjects.SelectedObjects[0]; 
            int itemIndex = listObjects.SelectedIndex; 
            // Confirm delete 
            DialogResult msgb = MessageBox.Show("Tem a certeza que quer eliminar este turno ("+f.str+")?", "Esta operação é irreversível!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); 
            if (msgb == DialogResult.No) 
                return;
            // Create command 
            String commandText = "pr_TurnosDELETE";
            SqlCommand command = new SqlCommand(commandText, cn);
            command.CommandType = CommandType.StoredProcedure;
            // Add vars 
            command.Parameters.Add("@Codigo", SqlDbType.Int);
            command.Parameters["@Codigo"].Value = f.codigo;
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
                    errorMessage = "Este turno não pode ser eliminado enquanto estiver atribuído a um funcionário!";
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
            // Validate if function shift is inside Nao Docente main shift 
            TimeSpan horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text); 
            TimeSpan horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text);
            if (horaInicio.CompareTo(horaFim) == 0)
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
            if (horaInicio.CompareTo(horaFim) > 0) 
            { 
                userfeedback = MessageBox.Show( 
                    "O horário de início é maior ou igual ao de fim! Tem a certeza que pretende continuar?", 
                    "Atenção!", 
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Exclamation 
                ); 
                if (userfeedback != DialogResult.Yes) 
                    return false; 
            } 
            return true; 
        } 
 
        private void submitForm(Turno turno) 
        { 
            /* 
             If submition for edit t!=null 
             If new submition t==null 
             */ 
            bool edit = (turno != null); 
            // Get form data 
            TimeSpan horaInicio = TimeSpan.Parse(panelFormFieldHoraInicio.Text); 
            TimeSpan horaFim = TimeSpan.Parse(panelFormFieldHoraFim.Text); 
            // Create command 
            String commandText = "INSERT INTO GestaoEscola.Turno VALUES (@ID, @HORAINICIO, @HORAFIM)"; 
            if (edit) 
                commandText = "UPDATE GestaoEscola.Turno SET horaInicio = @HORAINICIO, horaFim = @HORAFIM WHERE codigo = @ID"; 
            SqlCommand command = new SqlCommand(commandText, cn); 
            // Add vars 
            command.Parameters.Add("@ID", SqlDbType.Int);
            if (edit)
                command.Parameters["@ID"].Value = turno.codigo;
            else
                command.Parameters["@ID"].Value = lastId +1 ;
            command.Parameters.Add("@HORAINICIO", SqlDbType.Time); 
            command.Parameters["@HORAINICIO"].Value = horaInicio; 
            command.Parameters.Add("@HORAFIM", SqlDbType.Time); 
            command.Parameters["@HORAFIM"].Value = horaFim;
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
                    "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!\r\n" + ex.ToString(), 
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
                    turno = new Turno();
                    turno.codigo = lastId;
                    turno.horaInicio = horaInicio;
                    turno.horaFim = horaFim; 
                    listObjects.AddObject(turno); 
                } else 
                { 
                    // Get object on interface list and change attributes 
                    turno.horaInicio = horaInicio; 
                    turno.horaFim = horaFim; 
                } 
                // SHow feedback to user 
                String successMessage = "O turno foi adicionado com sucesso!"; 
                if (edit) 
                    successMessage = "O turno foi editado com sucesso";
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
            // Execute SQL query to get Docente rows 
            SqlCommand cmd = new SqlCommand("SELECT * FROM GestaoEscola.Turno", cn); 
            SqlDataReader reader = cmd.ExecuteReader(); 
            // Create list of Objects given the query results 
            List<Turno> tuplos = new List<Turno>(); 
            while (reader.Read()) 
            { 
                Turno t = new Turno(); 
                t.codigo = Int32.Parse(reader["codigo"].ToString()); 
                if (t.codigo > lastId) 
                    lastId = t.codigo; 
                t.horaInicio = TimeSpan.Parse(reader["horaInicio"].ToString()); 
                t.horaFim = TimeSpan.Parse(reader["horaFim"].ToString()); 
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
 
        private void panelFormButton_Click(object sender, EventArgs e) 
        {             
            // Execute operation 
            if (formValid()) 
            { 
                // Edit 
                if (listObjects.SelectedIndex >= 0) 
                { 
                    submitForm((Turno)listObjects.SelectedObjects[0]); 
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
