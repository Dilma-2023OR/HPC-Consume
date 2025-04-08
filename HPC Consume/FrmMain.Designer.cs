namespace HPC_Consume
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cBoxWorkOrder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxPartNum = new System.Windows.Forms.ComboBox();
            this.lblOpcode = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gBoxValidation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tBoxLabelA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxLabelB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tLayoutMessage = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tBoxReel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timerTextReset = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gBoxValidation.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tLayoutMessage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1869, 206);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(390, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1088, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "HPC Consume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.cBoxWorkOrder, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBoxPartNum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOpcode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChange, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 206);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1869, 151);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // cBoxWorkOrder
            // 
            this.cBoxWorkOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxWorkOrder.BackColor = System.Drawing.SystemColors.Control;
            this.cBoxWorkOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWorkOrder.Enabled = false;
            this.cBoxWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxWorkOrder.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.cBoxWorkOrder.FormattingEnabled = true;
            this.cBoxWorkOrder.Location = new System.Drawing.Point(850, 79);
            this.cBoxWorkOrder.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxWorkOrder.Name = "cBoxWorkOrder";
            this.cBoxWorkOrder.Size = new System.Drawing.Size(363, 42);
            this.cBoxWorkOrder.Sorted = true;
            this.cBoxWorkOrder.TabIndex = 5;
            this.cBoxWorkOrder.TabStop = false;
            this.cBoxWorkOrder.SelectedIndexChanged += new System.EventHandler(this.cBoxWorkOrder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(475, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de Parte:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(846, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Work Order:";
            // 
            // cBoxPartNum
            // 
            this.cBoxPartNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxPartNum.BackColor = System.Drawing.SystemColors.Control;
            this.cBoxPartNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPartNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPartNum.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.cBoxPartNum.FormattingEnabled = true;
            this.cBoxPartNum.Location = new System.Drawing.Point(479, 79);
            this.cBoxPartNum.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxPartNum.Name = "cBoxPartNum";
            this.cBoxPartNum.Size = new System.Drawing.Size(363, 42);
            this.cBoxPartNum.Sorted = true;
            this.cBoxPartNum.TabIndex = 4;
            this.cBoxPartNum.SelectedIndexChanged += new System.EventHandler(this.cBoxPartNum_SelectedIndexChanged);
            // 
            // lblOpcode
            // 
            this.lblOpcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpcode.AutoSize = true;
            this.lblOpcode.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lblOpcode.ForeColor = System.Drawing.Color.Black;
            this.lblOpcode.Location = new System.Drawing.Point(0, 5);
            this.lblOpcode.Margin = new System.Windows.Forms.Padding(0);
            this.lblOpcode.Name = "lblOpcode";
            this.lblOpcode.Size = new System.Drawing.Size(143, 46);
            this.lblOpcode.TabIndex = 7;
            this.lblOpcode.Text = "Opcode";
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChange.Enabled = false;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Ebrima", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.btnChange.ForeColor = System.Drawing.Color.Black;
            this.btnChange.Location = new System.Drawing.Point(1221, 78);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(169, 46);
            this.btnChange.TabIndex = 6;
            this.btnChange.TabStop = false;
            this.btnChange.Text = "Cambiar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gBoxValidation, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblVersion, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 357);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.96183F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.03817F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1869, 818);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // gBoxValidation
            // 
            this.gBoxValidation.Controls.Add(this.tableLayoutPanel5);
            this.gBoxValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxValidation.Font = new System.Drawing.Font("72 Black", 20F);
            this.gBoxValidation.ForeColor = System.Drawing.Color.Black;
            this.gBoxValidation.Location = new System.Drawing.Point(314, 436);
            this.gBoxValidation.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Name = "gBoxValidation";
            this.gBoxValidation.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Size = new System.Drawing.Size(1240, 346);
            this.gBoxValidation.TabIndex = 16;
            this.gBoxValidation.TabStop = false;
            this.gBoxValidation.Text = "Transacción de Material";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tBoxLabelA, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.tBoxLabelB, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.tLayoutMessage, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 43);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1232, 299);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tBoxLabelA
            // 
            this.tBoxLabelA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBoxLabelA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBoxLabelA.Enabled = false;
            this.tBoxLabelA.Font = new System.Drawing.Font("Century Gothic", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.tBoxLabelA.Location = new System.Drawing.Point(412, 62);
            this.tBoxLabelA.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxLabelA.MaxLength = 50;
            this.tBoxLabelA.Name = "tBoxLabelA";
            this.tBoxLabelA.Size = new System.Drawing.Size(407, 39);
            this.tBoxLabelA.TabIndex = 17;
            this.tBoxLabelA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxLabelA_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(408, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 46);
            this.label9.TabIndex = 17;
            this.label9.Text = "Etiqueta B:";
            // 
            // tBoxLabelB
            // 
            this.tBoxLabelB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBoxLabelB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBoxLabelB.Enabled = false;
            this.tBoxLabelB.Font = new System.Drawing.Font("Century Gothic", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.tBoxLabelB.Location = new System.Drawing.Point(412, 155);
            this.tBoxLabelB.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxLabelB.MaxLength = 50;
            this.tBoxLabelB.Name = "tBoxLabelB";
            this.tBoxLabelB.Size = new System.Drawing.Size(407, 39);
            this.tBoxLabelB.TabIndex = 10;
            this.tBoxLabelB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxLabelB_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(408, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Etiqueta A:";
            // 
            // tLayoutMessage
            // 
            this.tLayoutMessage.AutoSize = true;
            this.tLayoutMessage.BackColor = System.Drawing.Color.White;
            this.tLayoutMessage.ColumnCount = 1;
            this.tableLayoutPanel5.SetColumnSpan(this.tLayoutMessage, 3);
            this.tLayoutMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1228F));
            this.tLayoutMessage.Controls.Add(this.lblMessage, 0, 0);
            this.tLayoutMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutMessage.Location = new System.Drawing.Point(0, 198);
            this.tLayoutMessage.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutMessage.Name = "tLayoutMessage";
            this.tLayoutMessage.RowCount = 1;
            this.tLayoutMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutMessage.Size = new System.Drawing.Size(1232, 101);
            this.tLayoutMessage.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(524, 23);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(183, 55);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Default";
            this.lblMessage.TextChanged += new System.EventHandler(this.lblMessage_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.tableLayoutPanel5.SetRowSpan(this.label8, 4);
            this.label8.Size = new System.Drawing.Size(317, 50);
            this.label8.TabIndex = 12;
            this.label8.Text = "2) Escanee ambas etiquetas\r\npara dar el pase";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel7);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(314, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1240, 424);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de BOM";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tBoxReel, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label10, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnClean, 2, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 53);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1232, 367);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // tBoxReel
            // 
            this.tBoxReel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tBoxReel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBoxReel.Enabled = false;
            this.tBoxReel.Font = new System.Drawing.Font("Century Gothic", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.tBoxReel.Location = new System.Drawing.Point(412, 75);
            this.tBoxReel.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxReel.MaxLength = 100;
            this.tBoxReel.Name = "tBoxReel";
            this.tBoxReel.Size = new System.Drawing.Size(407, 39);
            this.tBoxReel.TabIndex = 14;
            this.tBoxReel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxReel_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(408, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 46);
            this.label10.TabIndex = 7;
            this.label10.Text = "Batch:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.tableLayoutPanel7.SetRowSpan(this.label11, 2);
            this.label11.Size = new System.Drawing.Size(368, 50);
            this.label11.TabIndex = 10;
            this.label11.Text = "1) Escanee los números de parte \r\ncuando se le solicite";
            // 
            // panel5
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.panel5, 3);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(4, 129);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.tableLayoutPanel7.SetRowSpan(this.panel5, 2);
            this.panel5.Size = new System.Drawing.Size(1220, 227);
            this.panel5.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClean.Enabled = false;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Ebrima", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.btnClean.Location = new System.Drawing.Point(943, 75);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(169, 46);
            this.btnClean.TabIndex = 6;
            this.btnClean.TabStop = false;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lblVersion.Location = new System.Drawing.Point(1795, 789);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(71, 25);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "2.0.0.7";
            // 
            // timerTextReset
            // 
            this.timerTextReset.Interval = 5000;
            this.timerTextReset.Tick += new System.EventHandler(this.timerTextReset_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1869, 1175);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "HPC Consume";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gBoxValidation.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tLayoutMessage.ResumeLayout(false);
            this.tLayoutMessage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cBoxWorkOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxPartNum;
        private System.Windows.Forms.Label lblOpcode;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gBoxValidation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox tBoxLabelA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxLabelB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tLayoutMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox tBoxReel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer timerTextReset;
    }
}