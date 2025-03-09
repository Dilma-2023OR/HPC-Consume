using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HPC_Consume.RuncardWebService;
namespace HPC_Consume
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        //Config Connection
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\HPC Consume\config.ini");

        //Runcard Connection
        runcard_wsdlPortTypeClient client = new runcard_wsdlPortTypeClient("runcard_wsdlPort");
        string msg = string.Empty;
        unitBOM[] getBOM = null;
        int error = 0;

        //List
        List<string> bomList = new List<string>();

        //Config Data
        string warehouseBin = string.Empty;
        string warehouseLoc = string.Empty;
        string partClass = string.Empty;
        string machineId = string.Empty;
        string opcode = string.Empty;
        string seqnum = string.Empty;
        string etiqnum = string.Empty;

        //General Data
        int bomCount = 0;
        int pos = 0;
        int contador = 0;
        bool valExist = false;
        int contDatagrid = 0;
        int etiqExpandor = 0;
        int errExpendor = 0;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(localConfig.FilePath)))
                {
                    //Config Directory
                    Directory.CreateDirectory(Path.GetDirectoryName(localConfig.FilePath));
                    File.Copy(Directory.GetCurrentDirectory() + "\\config.ini", localConfig.FilePath);
                }
                dataGridView1.DefaultCellStyle.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Ebrima", 19.8000011F, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
               
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                warehouseBin = localConfig.Read("RUNCARD_INFO", "warehouseBin");
                warehouseLoc = localConfig.Read("RUNCARD_INFO", "warehouseLoc");
                partClass = localConfig.Read("RUNCARD_INFO", "partClass");
                machineId = localConfig.Read("RUNCARD_INFO", "machineID");
                opcode = localConfig.Read("RUNCARD_INFO", "opcode");
                seqnum = localConfig.Read("RUNCARD_INFO", "seqnum");
                etiqnum = localConfig.Read("RUNCARD_INFO", "etiqnum");

                //Control Adjust
                //lblMachine.Text = machineId;
                lblOpcode.Text = opcode;
                lblMessage.Text = "";
                if (opcode == "A100")
                {
                    label1.Text = "HPC Consume";
                    //crear encabezados del datagridview
                    dataGridView1.Dock = DockStyle.Fill;

                    DataGridViewTextBoxColumn tbId = new DataGridViewTextBoxColumn();
                    tbId.HeaderText = "ID";
                    tbId.Name = "ID";
                    tbId.FillWeight = 50;
                    tbId.Width = 144;

                    dataGridView1.Columns.Add(tbId);

                    DataGridViewTextBoxColumn tbMaterial = new DataGridViewTextBoxColumn();
                    tbMaterial.HeaderText = "Material";
                    tbMaterial.Name = "Material";
                    tbMaterial.FillWeight = 100;
                    tbMaterial.Width = 287;

                    dataGridView1.Columns.Add(tbMaterial);

                    DataGridViewTextBoxColumn tbRev = new DataGridViewTextBoxColumn();
                    tbRev.HeaderText = "Rev";
                    tbRev.Name = "Rev";
                    tbRev.FillWeight = 50;
                    tbRev.Width = 144;

                    dataGridView1.Columns.Add(tbRev);

                    DataGridViewTextBoxColumn tbUniqueId = new DataGridViewTextBoxColumn();
                    tbUniqueId.HeaderText = "Unique Id";
                    tbUniqueId.Name = "UniqueId";
                    tbUniqueId.FillWeight = 100;
                    tbUniqueId.Width = 288;

                    dataGridView1.Columns.Add(tbUniqueId);

                    DataGridViewTextBoxColumn tbCantidad = new DataGridViewTextBoxColumn();
                    tbCantidad.HeaderText = "Cantidad";
                    tbCantidad.Name = "Cantidad";
                    tbCantidad.FillWeight = 55;
                    tbCantidad.Width = 158;

                    dataGridView1.Columns.Add(tbCantidad);

                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.HeaderText = "Eliminar";
                    btnEliminar.Name = "Eliminar";
                    btnEliminar.Text = "";
                    btnEliminar.FillWeight = 50;
                    btnEliminar.Width = 144;

                    btnEliminar.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(btnEliminar);

                    dataGridView1.ScrollBars = ScrollBars.Both;
                }
                else
                {
                    if (opcode == "A101")
                        label1.Text = "HPC Expando";
                    else if (opcode == "A103")
                        label1.Text = "HPC CUT";
                    else if (opcode == "A104")
                        label1.Text = "HPC Tie Bar";

                    //crear encabezados del datagridview
                    dataGridView1.Dock = DockStyle.Fill;

                    DataGridViewTextBoxColumn tbId = new DataGridViewTextBoxColumn();
                    tbId.HeaderText = "ID";
                    tbId.Name = "ID";
                    tbId.FillWeight = 50;
                    tbId.Width = 144;

                    dataGridView1.Columns.Add(tbId);

                    DataGridViewTextBoxColumn tbMaterial = new DataGridViewTextBoxColumn();
                    tbMaterial.HeaderText = "Material";
                    tbMaterial.Name = "Material";
                    tbMaterial.FillWeight = 100;
                    tbMaterial.Width = 287;

                    dataGridView1.Columns.Add(tbMaterial);

                    DataGridViewTextBoxColumn tbRev = new DataGridViewTextBoxColumn();
                    tbRev.HeaderText = "Rev";
                    tbRev.Name = "Rev";
                    tbRev.FillWeight = 50;
                    tbRev.Width = 144;

                    dataGridView1.Columns.Add(tbRev);

                    DataGridViewTextBoxColumn tbUniqueId = new DataGridViewTextBoxColumn();
                    tbUniqueId.HeaderText = "Unique Id";
                    tbUniqueId.Name = "UniqueId";
                    tbUniqueId.FillWeight = 100;
                    tbUniqueId.Width = 288;

                    dataGridView1.Columns.Add(tbUniqueId);

                    DataGridViewTextBoxColumn tbCantidad = new DataGridViewTextBoxColumn();
                    tbCantidad.HeaderText = "Cantidad";
                    tbCantidad.Name = "Cantidad";
                    tbCantidad.FillWeight = 55;
                    tbCantidad.Width = 158;

                    dataGridView1.Columns.Add(tbCantidad);

                }

                if (etiqnum == "1") 
                {
                    if (opcode == "A100" || opcode == "A103" || opcode == "A101" || opcode == "A104") {
                        tBoxLabelB.Visible = false;
                        label8.Text = "2) Escanee etiqueta para\r\ndar el pase";
                        label9.Visible = false;
                    }
                }
                else if (etiqnum == "2")
                {
                    if (opcode == "A100" || opcode == "A101")
                    {
                        tBoxLabelB.Visible = true;
                        label8.Text = "2) Escanee ambas etiquetas\r\npara dar el pase";
                        label9.Visible = true;
                    }
                    
                }

                //Temporal Data
                string dBMsg = string.Empty;
                int dBError = 0;

                //Data Base Connection 
                DBConnection dB = new DBConnection();
                DataTable dtResult = new DataTable();

                dB.dataBase = "datasource=mlxgumvlptfrd01.molex.com;port=3306;username=ftest;password=Ftest123#;database=runcard_tempflex;";
                dB.query = "SELECT partnum FROM runcard_tempflex.prod_master_config"
                         + " INNER JOIN runcard_tempflex.prod_step_config ON runcard_tempflex.prod_step_config.prr_config_id = runcard_tempflex.prod_master_config.prr_config_id AND runcard_tempflex.prod_step_config.prr_config_rev = runcard_tempflex.prod_master_config.prr_config_rev"
                         + " WHERE status = \"ACTIVE\" AND opcode = \"" + opcode + "\" AND part_class IN ('" + partClass + "');";
                var dBResult = dB.getData(out dBMsg, out dBError);

                if (dBError != 0)
                {
                    //Control Adjust
                    cBoxPartNum.Enabled = false;

                    //Feedback
                    Message message = new Message(dBMsg);
                    message.ShowDialog();
                    return;
                }

                //Fill Data Table
                dBResult.Fill(dtResult);
                foreach (DataRow row in dtResult.Rows)
                {
                    if (!cBoxPartNum.Items.Contains(row.ItemArray[0]))
                        cBoxPartNum.Items.Add(row.ItemArray[0]);
                }
            }
            catch (Exception ex)
            {
                //Control Adjust
                cBoxPartNum.Enabled = false;

                //Feedback
                Message message = new Message("Error al obtener la configuración");
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener la configuración:" + ex.Message + "\n");
            }
        }

        private void cBoxPartNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxPartNum.Text != string.Empty)
            {
                try
                {
                    //Clear Save Data
                    cBoxWorkOrder.Items.Clear();

                    //Get Work Orders
                    var getWorkOrders = client.getAvailableWorkOrders(cBoxPartNum.Text, "", out error, out msg);

                    foreach (workOrderItem order in getWorkOrders)
                        if (!cBoxWorkOrder.Items.Contains(order.workorder))
                            cBoxWorkOrder.Items.Add(order.workorder);

                    //Control Adjust
                    cBoxWorkOrder.Enabled = true;
                }
                catch (Exception ex)
                {
                    //Feedback
                    Message message = new Message("Error al obtener las ordenes");
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener las ordenes:" + ex.Message + "\n");
                }
            }
        }

        private void cBoxWorkOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxWorkOrder.Text != string.Empty)
            {
                //Control Adjust
                dataGridView1.Controls.Clear();

                try
                {
                    //Get BOM
                    getBOM = client.getUnitBOMConsumption(cBoxWorkOrder.Text, seqnum, out error, out msg);

                    if (getBOM.Length == 0)
                    {
                        Message message = new Message("La orden actual no cuenta con BOM");
                        message.ShowDialog();

                        //Log
                        File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",La orden actual no cuenta con BOM\n");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    //Retroalimentación
                    Message message = new Message("Error al obtener el BOM");
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al obtener el BOM:" + ex.Message + "\n");
                    return;
                }

                //Internal Counter
                int bom = 0;
                int row = 0;
                int col = 0;

                

                foreach (unitBOM item in getBOM)
                {
                    if (item.alt_for_item == 0)
                    {

                        if (opcode == "A100")
                        {
                            dataGridView1.Rows.Add(Convert.ToString(bomCount + 1), item.partnum, item.partrev, "-", "-", "check");

                            //Asignar la imagen a las celdas del DatagridviewButtonColumn
                            foreach (DataGridViewRow rows in dataGridView1.Rows)
                            {
                                rows.Cells["Eliminar"].Value = " "; // Esto es para que no se muestre texto
                                rows.Cells["Eliminar"].Style.BackColor = Color.LightBlue; // Color de fondo del botón
                                rows.Cells["Eliminar"].Style.ForeColor = Color.Black; // Color del texto

                                // Asignar la imagen a la celda del botón
                                rows.Cells["Eliminar"].Style.Font = new Font("Arial", 12);
                                rows.Cells["Eliminar"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                rows.Cells["Eliminar"].Style.NullValue = null; // Quitar valor por defecto de la celda
                                rows.Cells["Eliminar"].Style.Padding = new Padding(0); // Ajustar el espaciado
                            }

                            dataGridView1.CellPainting += dataGridView1_CellPainting;
                        }
                        else 
                            dataGridView1.Rows.Add(Convert.ToString(bomCount + 1), item.partnum, item.partrev, "-", "-");



                        //Counter
                        bomCount++;
                        bom++;

                        foreach (unitBOM subItem in getBOM)
                        {
                            if (subItem.alt_for_item == item.item)
                            {
                                //In case of altern add it
                                dataGridView1.Rows[1].Cells[bomCount-1].Value = dataGridView1.Rows[1].Cells[bomCount - 1].Value + "\n" + subItem.partnum;
                                dataGridView1.Rows[2].Cells[bomCount - 1].Value = dataGridView1.Rows[2].Cells[bomCount - 1].Value + "\n" + subItem.partrev;
                                break;
                            }
                        }
                    }

                    //habilitar barras de desplazamiento si el contenido excede el tamaño del datagridview
                    
                    cBoxWorkOrder.Enabled = false;
                    cBoxPartNum.Enabled = false;
                    dataGridView1.ResumeLayout();
                    btnChange.Enabled = true;

                    dataGridView1.ScrollBars = ScrollBars.Both;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                }
                //Check Data
                checkBOMData();
            }
        }

        private void checkBOMData()
        {
            //Temporal Data
            string missing = "";
            string desc = "";
            for (int x = 0; x < getBOM.Length; x++)
            {
               
                var CellValue = dataGridView1.Rows[x].Cells[3].Value;
                if (CellValue.ToString() == "-")
                    missing = missing + ", " + dataGridView1.Rows[x].Cells[1].Value.ToString();
               
                
            }

            if (missing.Length == 0)
            {
                //Control Adjust
                cBoxWorkOrder.Enabled = false; 
                cBoxPartNum.Enabled = false;
                tBoxLabelA.Enabled = true;
                tBoxLabelB.Enabled = true;
                tBoxReel.Enabled = true;
                btnChange.Enabled = true;
                tBoxLabelA.Focus();

                return;
            }
            foreach (char c in missing)
                if (!char.IsControl(c))
                    desc = desc + c;
                else if (c.Equals('\n'))
                    desc = desc + "/";


            //Control Adjust
            tBoxLabelA.Enabled = false;
            tBoxLabelB.Enabled = false;
            tBoxReel.Enabled = true;
            tBoxReel.Focus();
        }

        private void tBoxReel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & tBoxReel.Text != string.Empty)
            {
                try
                {
                    //Boleana
                    bool partBOM = false;

                    //Almacena el valor escaneado
                    string scanInfo = "";

                    tBoxLabelA.Enabled = false;
                    tBoxLabelB.Enabled = false;
                    valExist = false;
                    etiqExpandor = 0;
                    errExpendor = 0;

                    //Limpieza de controles
                    foreach (char c in tBoxReel.Text) {
                        if (!char.IsControl(c)) { 
                            scanInfo = scanInfo + c;
                        }
                    }

                    if (opcode == "A100" || opcode == "A103" )
                    {
                        try { 
                        //Si el dato empieza con los caracteres asignados
                        if (scanInfo.StartsWith("RG") | scanInfo.StartsWith("R") | scanInfo.StartsWith("G"))
                        {
                            //Si el uniqueId no esta vacío
                            if (scanInfo != "")
                            {
                                //Busqueda de la información del Id
                                var fetchInv = client.fetchInventoryItems(scanInfo, "", "", "", "", "", 0, "", "", out error, out msg);

                                //Si no falla y existe
                                if (error == 0 & fetchInv.Length > 0)
                                {
                                    //Almacenamiento de los datos
                                    string partStatus = fetchInv[0].status;
                                    string partNum = fetchInv[0].partnum;
                                    string partRev = fetchInv[0].partrev;
                                    string serial = fetchInv[0].serial;
                                    float quantity = fetchInv[0].qty;

                                    //Si la cantidad es mayor a 0 y esta disponible/Si la cantidad es mayor a 0 y esta recibido
                                    if (quantity > 0 & partStatus == "AVAILABLE" | quantity > 0 & partStatus == "RECEIVED")
                                    {
                                        //Por cada unidad del BOM
                                        foreach (unitBOM unit in getBOM)
                                        {
                                            //Sí el número de parte escaneado fue encontrado en el BOM
                                            if (unit.partnum == partNum & unit.partrev == partRev)
                                            {
                                                //Activa la Boleana
                                                partBOM = true;
                                                break;
                                            }
                                        }

                                        foreach (var item in getBOM)
                                        {
                                            if (item.partnum == fetchInv[0].partnum && item.partrev == fetchInv[0].partrev)
                                            {
                                                valExist = true;
                                                break;
                                            }
                                        }



                                        //Si pertenece al BOM
                                        if (partBOM)
                                        {
                                            //Se recorre cada fila
                                            for (int x = 0; x < bomCount; x++)
                                            {
                                                string PART = dataGridView1.Rows[x].Cells[1].Value.ToString();
                                                string REVISION = dataGridView1.Rows[x].Cells[2].Value.ToString();
                                                //Si el valor de la posicion contiene el número de parte y revisión
                                                if (PART == fetchInv[0].partnum & REVISION == fetchInv[0].partrev)
                                                {
                                                    //Si la posición de la tabla no ha sido asignado
                                                    if (dataGridView1.Rows[x].Cells[3].Value.ToString() == "-" & dataGridView1.Rows[x].Cells[4].Value.ToString() == "-")
                                                    {
                                                        //Añade los datos
                                                        dataGridView1.Rows[x].Cells[3].Value = serial;
                                                        dataGridView1.Rows[x].Cells[4].Value = quantity.ToString();

                                                        contador++;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Message message1 = new Message(scanInfo + " ya escaneado.");
                                                        message1.ShowDialog();
                                                        break;
                                                    }
                                                }
                                                else if (dataGridView1.Rows[x].Cells[1].Value.ToString().Contains(partNum) & !dataGridView1.Rows[x].Cells[2].Value.ToString().Contains(partRev))
                                                {
                                                    Message message2 = new Message("El número de parte escaneado no pertenece al BOM " + scanInfo + "," + partNum + "-" + partRev + ", notificar.");
                                                    message2.ShowDialog();
                                                    errExpendor = 1;
                                                }
                                            }
                                            Message message = new Message("BOM COMPLETADO");
                                        }
                                        else
                                        {
                                            Message message = new Message("El número de parte escaneado no pertenece al BOM " + scanInfo + "," + partNum + "-" + partRev + ", notificar.");
                                            message.ShowDialog();
                                            errExpendor = 1;
                                        }
                                    }
                                    else
                                    {
                                        Message message = new Message(scanInfo + ", cantidad " + quantity + ", " + fetchInv[0].status + ".");
                                        message.ShowDialog();
                                        errExpendor = 1;
                                    }
                                }
                                else
                                {
                                    //Log
                                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + scanInfo + ", Serial no registrado en sistema.\n");

                                    Message message = new Message(scanInfo + ", Serial no registrado en sistema.");
                                    message.ShowDialog();
                                    errExpendor = 1;
                                }

                            }
                        }
                        }catch (Exception ex)
                        {
                            //Log
                            File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + scanInfo + ", El escaneo no pertenece al BOM, no es UNIQUE ID.\n");

                            Message message = new Message(scanInfo + ", El escaneo no pertenece al BOM, no es UNIQUE ID.");
                            message.ShowDialog();
                            errExpendor = 1;
                        }
                    }
                    else {
                        
                        //Si el uniqueId no esta vacío
                        if (scanInfo != "")
                        {
                            //Busqueda de la información del Id
                            var fetchInv = client.fetchInventoryItems(scanInfo, "", "", "", "", "", 0, "", "", out error, out msg);

                            //Si no falla y existe
                            if (error == 0 & fetchInv.Length > 0)
                            {
                                //Almacenamiento de los datos
                                string partStatus = fetchInv[0].status;
                                string partNum = fetchInv[0].partnum;
                                string partRev = fetchInv[0].partrev;
                                string serial = fetchInv[0].serial;
                                float quantity = fetchInv[0].qty;

                                //Si la cantidad es mayor a 0 y esta disponible/Si la cantidad es mayor a 0 y esta recibido
                                if (quantity > 0 & partStatus == "COMPLETE" || partStatus == "AVAILABLE")
                                {
                                    //Por cada unidad del BOM
                                    foreach (unitBOM unit in getBOM)
                                    {
                                        //Sí el número de parte escaneado fue encontrado en el BOM
                                        if (unit.partnum == partNum & unit.partrev == partRev)
                                        {
                                            //Activa la Boleana
                                            partBOM = true;
                                            break;
                                        }
                                    }

                                    foreach (var item in getBOM)
                                    {
                                        if (item.partnum == fetchInv[0].partnum && item.partrev == fetchInv[0].partrev)
                                        {
                                            valExist = true;
                                            break;
                                        }
                                    }



                                    //Si pertenece al BOM
                                    if (partBOM)
                                    {
                                        //Se recorre cada fila
                                        for (int x = 0; x < bomCount; x++)
                                        {
                                            string PART = dataGridView1.Rows[x].Cells[1].Value.ToString();
                                            string REVISION = dataGridView1.Rows[x].Cells[2].Value.ToString();
                                            //Si el valor de la posicion contiene el número de parte y revisión
                                            if (PART == fetchInv[0].partnum & REVISION == fetchInv[0].partrev)
                                            {
                                                //Si la posición de la tabla no ha sido asignado
                                                if (dataGridView1.Rows[x].Cells[3].Value.ToString() == "-" & dataGridView1.Rows[x].Cells[4].Value.ToString() == "-")
                                                {
                                                    //Añade los datos
                                                    dataGridView1.Rows[x].Cells[3].Value = serial;
                                                    dataGridView1.Rows[x].Cells[4].Value = quantity.ToString();


                                                    break;
                                                }
                                                else
                                                {
                                                    Message message1 = new Message(scanInfo + " ya escaneado.");
                                                    message1.ShowDialog();
                                                    break;
                                                }
                                                
                                            }
                                            else if (dataGridView1.Rows[x].Cells[2].Value.ToString().Contains(partNum) & !dataGridView1.Rows[x].Cells[3].Value.ToString().Contains(partRev))
                                            {
                                                Message message2 = new Message("El número de parte escaneado no pertenece al BOM " + scanInfo + "," + partNum + "-" + partRev + ", notificar.");
                                                message2.ShowDialog();
                                                errExpendor = 1;
                                            }
                                        }
                                        Message message = new Message("BOM COMPLETADO");
                                    }
                                    else
                                    {
                                        Message message = new Message("El número de parte escaneado no pertenece al BOM " + scanInfo + "," + partNum + "-" + partRev + ", notificar.");
                                        message.ShowDialog();
                                        errExpendor = 1;
                                    }
                                }
                                else
                                {
                                    Message message = new Message(scanInfo + ", cantidad " + quantity + ", " + fetchInv[0].status + ".");
                                    message.ShowDialog();
                                    errExpendor = 1;


                                }
                            }
                            else
                            {
                                //Log
                                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + scanInfo + ", Serial no registrado en sistema.\n");

                                Message message = new Message(scanInfo + ", Serial no registrado en sistema.");
                                message.ShowDialog();
                                errExpendor = 1;


                            }

                        }
                        
                    }

                    tLayoutMessage.BackColor = Color.White;
                    lblMessage.Text = "";

                    //Check Data
                    checkBOMData();

                    //Control Adjust
                    tBoxReel.Clear();
                    tBoxReel.Focus();
                    btnClean.Enabled = true;

                    if (opcode == "A100")
                    {
                        if (contador == 8)
                        {
                            tBoxReel.Enabled = false;
                            Message message = new Message("BOM COMPLETADO");
                            message.ShowDialog();
                            tBoxReel.Enabled = false;
                            tBoxLabelA.Enabled = true;
                            tBoxLabelA.Focus();
                            tBoxLabelB.Enabled = true;
                        }
                    }
                    else
                    if (opcode == "A101" || opcode == "A104" || opcode == "A103" & errExpendor == 0)
                    {
                        tBoxReel.Enabled = false;
                        tBoxLabelA.Enabled = true;
                        tBoxLabelA.Focus();
                        tBoxLabelB.Enabled = true;
                    }
                }
                catch (Exception ex) {
                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al consultar el status del serial "+ ex.Message + "\n");

                }
            }
        }

        private void tBoxLabelA_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Enter & tBoxLabelA.Text != string.Empty)
            {
                string scanInfo = "";

                foreach (char c in tBoxLabelA.Text) {
                    if (!char.IsControl(c))
                    { 
                        scanInfo = scanInfo + c;
                    }
                }

                if (scanInfo.StartsWith("25"))
                {
                    if (etiqnum == "1" & opcode == "A100" || opcode == "A103" || opcode == "A104")
                    {
                        //Temporal Data
                        int response = 0;

                        //Register Unit
                        serialRegister(tBoxLabelA.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelA.Clear();
                            tBoxLabelA.Focus();
                            return;
                        }

                        //Transaction Unit
                        serialTransaction(tBoxLabelA.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelA.Clear();
                            tBoxLabelA.Focus();
                            return;
                        }

                        //Control Adjust
                        tBoxLabelA.Enabled = true;
                        tBoxReel.Enabled = false;
                        tBoxLabelA.Clear();
                        tBoxReel.Clear();
                        tBoxLabelA.Focus();

                    }
                    else
                    if (etiqnum == "1" & opcode == "A101")
                    {
                        //Temporal Data
                        int response = 0;

                        //Register Unit
                        serialRegister(tBoxLabelA.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelA.Clear();
                            tBoxLabelA.Focus();
                            return;
                        }

                        //Transaction Unit
                        serialTransaction(tBoxLabelA.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelA.Clear();
                            tBoxLabelA.Focus();
                            return;
                        }

                        //Control Adjust
                        tBoxLabelA.Enabled = false;
                        tBoxReel.Enabled = true;
                        tBoxLabelA.Clear();
                        tBoxReel.Clear();
                        tBoxReel.Focus();
                    }
                    if (etiqnum == "2" || opcode == "A101")
                    {
                        //Temporal Data
                        int response = 0;

                        //Register Unit
                        serialRegister(tBoxLabelA.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelA.Clear();
                            tBoxLabelA.Focus();
                            return;
                        }

                        //Transaction Unit
                        serialTransaction(tBoxLabelA.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelA.Enabled = false;
                            tBoxLabelB.Focus();
                            return;
                        }

                        //Control Adjust
                        tBoxLabelA.Enabled = false;
                        tBoxLabelB.Enabled = true;
                        tBoxLabelA.Clear();
                        tBoxLabelB.Clear();
                        tBoxLabelB.Focus();
                    }
                }
                else
                {
                    //LOG
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "La etiqueta: " + scanInfo + ", No pertenece a HPC Expando.\n");

                    Message message = new Message("La etiqueta: " + scanInfo + ", No pertenece a HPC Expando.");
                    message.ShowDialog();
                    errExpendor = 1;
                }
            }
        }

        private void tBoxLabelB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & tBoxLabelB.Text != string.Empty)
            {
                string scanInfo = "";

                foreach (char c in tBoxLabelB.Text)
                {
                    if (!char.IsControl(c))
                    {
                        scanInfo = scanInfo + c;
                    }
                }

                if (scanInfo.StartsWith("25"))
                {
                    if (opcode == "A100")
                    {
                        //Temporal Data
                        int response = 0;

                        //Register Unit
                        serialRegister(tBoxLabelB.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelB.Clear();
                            tBoxLabelB.Focus();
                            return;
                        }

                        //Transaction Unit
                        serialTransaction(tBoxLabelB.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelB.Clear();
                            tBoxLabelB.Focus();
                            return;
                        }

                        //Control Adjust
                        tBoxLabelA.Enabled = true;
                        tBoxLabelA.Clear();
                        tBoxLabelB.Clear();
                        tBoxLabelA.Focus();
                    }
                    else
                    {
                        //Temporal Data
                        int response = 0;

                        //Register Unit
                        serialRegister(tBoxLabelB.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelB.Clear();
                            tBoxLabelB.Focus();
                            return;
                        }

                        //Transaction Unit
                        serialTransaction(tBoxLabelB.Text, out response);

                        if (response != 0)
                        {
                            //Control Adjust
                            tBoxLabelB.Clear();
                            tBoxLabelB.Focus();
                            return;
                        }

                        //Control Adjust
                        tBoxLabelB.Enabled = false;
                        tBoxReel.Enabled = true;
                        tBoxReel.Clear();
                        tBoxLabelA.Clear();
                        tBoxLabelB.Clear();
                        tBoxReel.Focus();
                    }
                }
                else
                {
                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "La etiqueta: " + scanInfo + ", No pertenece a HPC Expando.\n");

                    Message message = new Message("La etiqueta: " + scanInfo + ", No pertenece a HPC Expando.");
                    message.ShowDialog();
                    errExpendor = 1;
                }
            }
        }

        private void serialRegister(string serial, out int response)
        {
            int register = -1;
            response = 0;
            int qty = 0;
            try
            {
                if (opcode == "A103")
                    qty = 500;
                else if (opcode == "A100")
                    qty = 2;
                else
                    qty = 1;

                register = client.registerUnitToWorkOrder(cBoxWorkOrder.Text, serial, qty, "", "", "WIP", "PRODUCTION FLOOR", "ftest", out string msg);

                if (error != 0)
                {
                    //Retroalimentación
                    Message message = new Message("Error al registrar el serial " + serial);
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al registar el serial " + serial + ":" + msg + "\n");

                    //Response
                    response = -1;
                    return;
                }

                //if (msg.Contains("is already registered"))
                //{
                //    //Retroalimentación
                //    Message message = new Message("Serial " + serial + " YA registrado");
                //    message.ShowDialog();

                //    //Log
                //    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "Serial " + serial + " YA registrado:" + msg + "\n");

                //    //Response
                //    response = 1;
                //    return;
                //}
            }
            catch (Exception ex)
            {
                //Feedback
                Message message = new Message("Error al registar el serial " + serial);
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al registar el serial " + serial + ":" + ex.Message + "\n");

                //Response
                response = -1;
            }
        }

        private void serialTransaction(string serial, out int response)
        {
            InventoryItem[] fetchInv = null;
            string workorder = string.Empty;
            string operation = string.Empty;
            string partnum = string.Empty;
            string partrev = string.Empty;
            string status = string.Empty;
            int step = 0;

            //Response
            response = 0;

            try
            {
                fetchInv = client.fetchInventoryItems(serial, "", "", "", "", "", 0, "", "", out error, out msg);
                workorder = fetchInv[0].workorder;
                operation = fetchInv[0].opcode;
                partnum = fetchInv[0].partnum;
                partrev = fetchInv[0].partrev;
                status = fetchInv[0].status;
                step = fetchInv[0].seqnum;
            }
            catch (Exception ex)
            {
                //Feedback
                Message message = new Message("Error al consultar el status del serial " + serial);
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al consultar el status del serial " + serial + ":" + ex.Message + "\n");

                //Response
                response = -1;
                return;
            }

            if (status == "IN QUEUE" & operation == opcode | status == "IN PROGRESS" & operation == opcode)
            {
                //Transaction Item
                transactionItem transItem = new transactionItem();
                transItem.workorder = cBoxWorkOrder.Text;
                transItem.warehouseloc = warehouseLoc;
                transItem.warehousebin = warehouseBin;
                transItem.username = "ftest";
                transItem.machine_id = machineId;
                transItem.transaction = "MOVE";
                transItem.opcode = operation;
                transItem.serial = serial;
                if (opcode == "A103")
                    transItem.trans_qty = 250;
                else if (opcode == "A100")
                    transItem.trans_qty = 2;
                else
                    transItem.trans_qty = 1;
                transItem.seqnum = step;
                transItem.comment = "TRANSACCION HECHA POR SISTEMA";

                //Data/BOM Item
                bomItem[] bomData = new bomItem[getBOM.Length];
                dataItem[] inputData = new dataItem[] { };

                //Counter
                int bom = 0;

                //Seriales para retirar
                List<string> partToRemove = new List<string>();
                string partnum1 = string.Empty;
                string uniqueId = string.Empty;
                int cantidad = 0; 
                string rev = string.Empty;  

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //Split Line
                    //string[] splitLine = line.Split(',');
                    uniqueId = row.Cells[3].Value.ToString();
                    partnum1 = row.Cells[1].Value.ToString();
                    rev = row.Cells[2].Value.ToString();

                    if (opcode == "A100" || opcode == "A103")
                        cantidad = Convert.ToInt32(row.Cells[4].Value.ToString());
                    else if (opcode == "A101" || opcode == "A104")
                    {
                        cantidad = Convert.ToInt32(row.Cells[4].Value.ToString());
                        etiqExpandor++;
                    }

                    //Load BOM
                    bomData[bom] = new bomItem();
                    bomData[bom].item_serial = uniqueId;
                    bomData[bom].item_partnum = partnum1;
                    bomData[bom].item_partrev = rev;

                    foreach (unitBOM part in getBOM)
                        if (partnum1 == part.partnum)
                        {
                            if (opcode == "A103")
                                //Load BOM
                                bomData[bom].item_qty = 250;
                            else if (opcode == "A100")
                                bomData[bom].item_qty = 2;
                            else
                                bomData[bom].item_qty = 1;

                            //Por cada pieza del BOM
                            for (int x = 0; x < dataGridView1.Rows.Count; x++)
                            {
                                //Si el número de parte coincide con el encontrado
                                if (partnum1.Contains(part.partnum))
                                {
                                    if (uniqueId.ToString() != "-")
                                    {
                                        if(opcode == "A100" || opcode == "A103" || opcode == "A104")
                                        { 
                                            //Nueva cantidad con el descuento
                                            //dataGridView1.Rows[x].Cells[5].Value = (cantidad - part.qty).ToString();
                                            cantidad = (cantidad - Convert.ToInt32(part.qty));

                                            //Si el id expiro
                                            if (cantidad <= 0)
                                            {
                                                //Reinicia los valores del campo
                                                dataGridView1.Rows[x].Cells[3].Value = "-";
                                                dataGridView1.Rows[x].Cells[4].Value = "-";

                                                //
                                                partToRemove.Add(part.partnum);

                                                tBoxLabelA.Enabled = true;
                                            }

                                            dataGridView1.Rows[x].Cells[4].Value = Convert.ToString(cantidad);
                                        }
                                        else if (opcode == "A101")
                                        {
                                            //Nueva cantidad con el descuento
                                            cantidad = (cantidad - 1);

                                            //Si el id expiro
                                            if (etiqExpandor ==2)
                                            {
                                                //Reinicia los valores del campo
                                                dataGridView1.Rows[x].Cells[3].Value = "-";
                                                dataGridView1.Rows[x].Cells[4].Value = "-";

                                                //
                                                partToRemove.Add(part.partnum);

                                                tBoxReel.Enabled = true;
                                                tBoxLabelA.Enabled = false;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }

                    //Count
                    bom++;

                    if (dataGridView1.Rows.Count == 0)
                        break;
                    }

                try
                {
                    //Transaction
                    var transaction = client.transactUnit(transItem, inputData, bomData, out msg);

                    //MessageBox.Show(msg);
                    if (!msg.Contains("ADVANCE"))
                    {
                        //Feedback
                        lblMessage.Text = "Pase NO otorgado al serial " + serial;
                        tLayoutMessage.BackColor = Color.Crimson;
                        MostrarMensajeFlotanteNoPass(" NO PASS");

                        //Log
                        File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Pase NO otorgado al serial " + serial + ":" + msg + "\n");

                        //Response
                        response = -1;
                        return;
                    }

                    //Feedback
                    lblMessage.Text = "Serial " + serial + " Completado";
                    tLayoutMessage.BackColor = Color.FromArgb(58, 196, 123);
                    MostrarMensajeFlotante("P A S S");

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\Log.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "," + msg + "\n");
                }
                catch (Exception ex)
                {
                    //Feedback
                    Message message = new Message("Error al dar el pase al serial " + serial);
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ",Error al dar el pase al serial " + serial + ":" + ex.Message + "\n");
                    //Response
                    response = -1;
                    return;
                }
            }
            else
            {
                //Get Instructions
                var getInstructions = client.getWorkOrderStepInstructions(cBoxWorkOrder.Text, step.ToString(), out error, out msg);

                //Feedback
                lblMessage.Text = "Serial " + serial + " sin flujo, " + status + ":" + getInstructions.opdesc;
                tLayoutMessage.BackColor = Color.Crimson;

                //Response
                response = -1;
            }
        }

        // Método para mostrar el mensaje flotante gigante
        private void MostrarMensajeFlotante(string mensaje)
        {
            // Crear un formulario emergente flotante
            Form flotanteForm = new Form();
            flotanteForm.FormBorderStyle = FormBorderStyle.None;  // Sin bordes
            flotanteForm.StartPosition = FormStartPosition.CenterScreen;  // Centrado en la pantalla
            flotanteForm.BackColor = Color.Green;  // Fondo verde (puedes cambiar el color)
            flotanteForm.Opacity = 0.9;  // Opacidad para hacerlo semitransparente
            flotanteForm.TopMost = true;  // Asegura que esté sobre otras ventanas
            flotanteForm.Width = 600;  // Ancho de la ventana flotante
            flotanteForm.Height = 200;  // Alto de la ventana flotante

            // Crear un label para mostrar el mensaje
            Label mensajeLabel = new Label();
            mensajeLabel.AutoSize = false;
            mensajeLabel.Size = new Size(flotanteForm.Width, flotanteForm.Height);
            mensajeLabel.Text = mensaje;
            mensajeLabel.Font = new Font("Arial", 48, FontStyle.Bold);  // Tamaño grande de la fuente
            mensajeLabel.ForeColor = Color.White;  // Color de texto blanco
            mensajeLabel.TextAlign = ContentAlignment.MiddleCenter;  // Centrado en el label

            // Añadir el label al formulario flotante
            flotanteForm.Controls.Add(mensajeLabel);

            // Mostrar el mensaje durante 3 segundos y luego cerrar
            flotanteForm.Show();
            Timer timer = new Timer();
            timer.Interval = 3000;  // 3000 milisegundos = 3 segundos
            timer.Tick += (sender, e) =>
            {
                flotanteForm.Close();
                timer.Stop();
            };
            timer.Start();
        }

        private void MostrarMensajeFlotanteNoPass(string mensaje)
        {
            // Crear un formulario emergente flotante
            Form flotanteForm = new Form();
            flotanteForm.FormBorderStyle = FormBorderStyle.None;  // Sin bordes
            flotanteForm.StartPosition = FormStartPosition.CenterScreen;  // Centrado en la pantalla
            flotanteForm.BackColor = Color.Red;  // Fondo verde (puedes cambiar el color)
            flotanteForm.Opacity = 0.9;  // Opacidad para hacerlo semitransparente
            flotanteForm.TopMost = true;  // Asegura que esté sobre otras ventanas
            flotanteForm.Width = 600;  // Ancho de la ventana flotante
            flotanteForm.Height = 200;  // Alto de la ventana flotante

            // Crear un label para mostrar el mensaje
            Label mensajeLabel = new Label();
            mensajeLabel.AutoSize = false;
            mensajeLabel.Size = new Size(flotanteForm.Width, flotanteForm.Height);
            mensajeLabel.Text = mensaje;
            mensajeLabel.Font = new Font("Arial", 48, FontStyle.Bold);  // Tamaño grande de la fuente
            mensajeLabel.ForeColor = Color.White;  // Color de texto blanco
            mensajeLabel.TextAlign = ContentAlignment.MiddleCenter;  // Centrado en el label

            // Añadir el label al formulario flotante
            flotanteForm.Controls.Add(mensajeLabel);

            // Mostrar el mensaje durante 3 segundos y luego cerrar
            flotanteForm.Show();
            Timer timer = new Timer();
            timer.Interval = 3000;  // 3000 milisegundos = 3 segundos
            timer.Tick += (sender, e) =>
            {
                flotanteForm.Close();
                timer.Stop();
            };
            timer.Start();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //Control Adjust
            tLayoutMessage.BackColor = Color.White;
            cBoxWorkOrder.SelectedIndex = -1;
            cBoxPartNum.SelectedIndex = -1;
            cBoxWorkOrder.Enabled = false;
            dataGridView1.Rows.Clear();
            cBoxPartNum.Enabled = true;
            tBoxLabelA.Enabled = false;
            tBoxLabelB.Enabled = false;
            btnChange.Enabled = false;
            tBoxReel.Enabled = false;
            lblMessage.Text = "";
            bomList.Clear();
            bomCount = 0;
            contador = 0;
        }

        private void lblMessage_TextChanged(object sender, EventArgs e)
        {
            //Timer Start
            timerTextReset.Start();
        }

        private void timerTextReset_Tick(object sender, EventArgs e)
        {
            //Timer Stop
            timerTextReset.Stop();

            //Control Adjust
            tLayoutMessage.BackColor = Color.White;
            lblMessage.Text = string.Empty;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            //Control Adjust
            tLayoutMessage.BackColor = Color.White;
            tBoxLabelA.Enabled = false;
            tBoxLabelB.Enabled = false;
            btnChange.Enabled = true;
            tBoxReel.Enabled = true;
            lblMessage.Text = "";
            

            for (int x = 0; x < getBOM.Length; x++)
            {
                if (opcode == "A100" || opcode == "A101" || opcode == "A103" || opcode == "A104")
                {
                    dataGridView1.Rows[x].Cells["UniqueId"].Value = "-";
                    dataGridView1.Rows[x].Cells["Cantidad"].Value = "-";

                    contador = 0;
                }
                else 
                if (opcode == "A100" || opcode == "A104")
                {
                    contador--;
                }
            }
            //Check BOM Data
            checkBOMData();
            tBoxReel.Clear();
            tBoxReel.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (opcode == "A100")
            {
                //Verificar que la celda clickeada este en la columna del checkbox
                if (e.ColumnIndex == 5)
                {
                    //Verificar que la fila no sea la fila de nueva entrada
                    if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
                    {

                        if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                        {
                            string unique = dataGridView1.Rows[e.RowIndex].Cells["UniqueId"].Value.ToString();
                            string materi = dataGridView1.Rows[e.RowIndex].Cells["Material"].Value.ToString();

                            DialogResult result = MessageBox.Show("¿Desea eliminar el uniqueId: " + unique +", número de parte: " +materi+"?", "Avertencia",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            //Verificar la respuesta del usuario
                            if (result == DialogResult.Yes)
                            {
                                dataGridView1.Rows[e.RowIndex].Cells["UniqueId"].Value = "-";
                                dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value = "-";
                                contador--;
                                tBoxReel.Enabled = true;
                                tBoxLabelA.Enabled = false;
                                tBoxLabelB.Enabled = false;

                                Message message = new Message("Material Eliminado");
                                message.ShowDialog();
                            }
                        }
                    }
                }
                
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (opcode == "A100")
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
                {
                    var rect = e.CellBounds;
                    Image img = Properties.Resources.eliminar;

                    // Escalar la imagen a un tamaño más pequeño
                    int imageWidth = 30; // Ancho de la imagen deseado
                    int imageHeight = 30; // Alto de la imagen deseado
                    img = new Bitmap(img, new Size(imageWidth, imageHeight)); // Redimensionar la imagen

                    // Calcular la posición para centrar la imagen en la celda
                    int x = rect.Left + (rect.Width - img.Width) / 2;
                    int y = rect.Top + (rect.Height - img.Height) / 2;
                    // Dibujar la imagen escalada en el botón
                    e.Graphics.DrawImage(img, x, y, img.Width, img.Height);
                    e.Handled = true;
                }
            }
        }
    }
}
