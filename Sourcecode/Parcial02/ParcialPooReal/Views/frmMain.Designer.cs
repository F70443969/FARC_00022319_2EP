﻿namespace ParcialPooReal.Views
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chAdmin = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDirectionRefresh = new System.Windows.Forms.Button();
            this.dgvDirections = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.btnDirectionAction = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBusiRefresh = new System.Windows.Forms.Button();
            this.dgvBusi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBusiCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusiDesc = new System.Windows.Forms.TextBox();
            this.txtBusiName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBusiAction = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProRefresh = new System.Windows.Forms.Button();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.cmbProBusi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirections)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPro)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(14, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.dtvUsers);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seleccionar con doble click al usuario para eliminarlo";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(477, 258);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 27);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refrescar Tabla";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // dtvUsers
            // 
            this.dtvUsers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUsers.Location = new System.Drawing.Point(334, 48);
            this.dtvUsers.Name = "dtvUsers";
            this.dtvUsers.ReadOnly = true;
            this.dtvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUsers.Size = new System.Drawing.Size(400, 203);
            this.dtvUsers.TabIndex = 19;
            this.dtvUsers.CellMouseDoubleClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtvUsers_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chAdmin);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 207);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // chAdmin
            // 
            this.chAdmin.AutoSize = true;
            this.chAdmin.Location = new System.Drawing.Point(78, 91);
            this.chAdmin.Name = "chAdmin";
            this.chAdmin.Size = new System.Drawing.Size(102, 19);
            this.chAdmin.TabIndex = 21;
            this.chAdmin.Text = "Administrador";
            this.chAdmin.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(78, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(78, 140);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 27);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnDirectionRefresh);
            this.tabPage2.Controls.Add(this.dgvDirections);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Mi direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Seleccionar con click a la dirección para modificarla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Seleccionar con doble click a la dirección para eliminarla";
            // 
            // btnDirectionRefresh
            // 
            this.btnDirectionRefresh.BackColor = System.Drawing.Color.Black;
            this.btnDirectionRefresh.ForeColor = System.Drawing.Color.White;
            this.btnDirectionRefresh.Location = new System.Drawing.Point(470, 252);
            this.btnDirectionRefresh.Name = "btnDirectionRefresh";
            this.btnDirectionRefresh.Size = new System.Drawing.Size(134, 27);
            this.btnDirectionRefresh.TabIndex = 24;
            this.btnDirectionRefresh.Text = "Refrescar Tabla";
            this.btnDirectionRefresh.UseVisualStyleBackColor = false;
            this.btnDirectionRefresh.Click += new System.EventHandler(this.btnDirectionRefresh_Click);
            // 
            // dgvDirections
            // 
            this.dgvDirections.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirections.Location = new System.Drawing.Point(327, 42);
            this.dgvDirections.Name = "dgvDirections";
            this.dgvDirections.ReadOnly = true;
            this.dgvDirections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirections.Size = new System.Drawing.Size(400, 203);
            this.dgvDirections.TabIndex = 23;
            this.dgvDirections.CellMouseClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDirections_CellMouseClick);
            this.dgvDirections.CellMouseDoubleClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDirections_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.txtDirection);
            this.groupBox2.Controls.Add(this.btnDirectionAction);
            this.groupBox2.Location = new System.Drawing.Point(26, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 240);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mi dirección";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(80, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(20, 22);
            this.txtDirection.Multiline = true;
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(212, 99);
            this.txtDirection.TabIndex = 0;
            // 
            // btnDirectionAction
            // 
            this.btnDirectionAction.BackColor = System.Drawing.Color.Black;
            this.btnDirectionAction.ForeColor = System.Drawing.Color.White;
            this.btnDirectionAction.Location = new System.Drawing.Point(80, 140);
            this.btnDirectionAction.Name = "btnDirectionAction";
            this.btnDirectionAction.Size = new System.Drawing.Size(87, 27);
            this.btnDirectionAction.TabIndex = 16;
            this.btnDirectionAction.Text = "Registrar";
            this.btnDirectionAction.UseVisualStyleBackColor = false;
            this.btnDirectionAction.Click += new System.EventHandler(this.btnDirectionAction_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnBusiRefresh);
            this.tabPage3.Controls.Add(this.dgvBusi);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Negocios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Seleccionar con click a la dirección para modificarla";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Seleccionar con doble click a la dirección para eliminarla";
            // 
            // btnBusiRefresh
            // 
            this.btnBusiRefresh.BackColor = System.Drawing.Color.Black;
            this.btnBusiRefresh.ForeColor = System.Drawing.Color.White;
            this.btnBusiRefresh.Location = new System.Drawing.Point(486, 268);
            this.btnBusiRefresh.Name = "btnBusiRefresh";
            this.btnBusiRefresh.Size = new System.Drawing.Size(134, 27);
            this.btnBusiRefresh.TabIndex = 28;
            this.btnBusiRefresh.Text = "Refrescar Tabla";
            this.btnBusiRefresh.UseVisualStyleBackColor = false;
            this.btnBusiRefresh.Click += new System.EventHandler(this.btnBusiRefresh_Click);
            // 
            // dgvBusi
            // 
            this.dgvBusi.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusi.Location = new System.Drawing.Point(343, 52);
            this.dgvBusi.Name = "dgvBusi";
            this.dgvBusi.ReadOnly = true;
            this.dgvBusi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusi.Size = new System.Drawing.Size(400, 203);
            this.dgvBusi.TabIndex = 27;
            this.dgvBusi.CellMouseClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusi_CellMouseClick);
            this.dgvBusi.CellMouseDoubleClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBusi_CellMouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBusiCancel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtBusiDesc);
            this.groupBox3.Controls.Add(this.txtBusiName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBusiAction);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 305);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del negocio";
            // 
            // btnBusiCancel
            // 
            this.btnBusiCancel.BackColor = System.Drawing.Color.Black;
            this.btnBusiCancel.ForeColor = System.Drawing.Color.White;
            this.btnBusiCancel.Location = new System.Drawing.Point(173, 261);
            this.btnBusiCancel.Name = "btnBusiCancel";
            this.btnBusiCancel.Size = new System.Drawing.Size(87, 27);
            this.btnBusiCancel.TabIndex = 20;
            this.btnBusiCancel.Text = "Cancelar";
            this.btnBusiCancel.UseVisualStyleBackColor = false;
            this.btnBusiCancel.Visible = false;
            this.btnBusiCancel.Click += new System.EventHandler(this.btnBusiCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Descripción";
            // 
            // txtBusiDesc
            // 
            this.txtBusiDesc.Location = new System.Drawing.Point(87, 65);
            this.txtBusiDesc.Multiline = true;
            this.txtBusiDesc.Name = "txtBusiDesc";
            this.txtBusiDesc.Size = new System.Drawing.Size(212, 177);
            this.txtBusiDesc.TabIndex = 1;
            // 
            // txtBusiName
            // 
            this.txtBusiName.Location = new System.Drawing.Point(87, 31);
            this.txtBusiName.Name = "txtBusiName";
            this.txtBusiName.Size = new System.Drawing.Size(212, 23);
            this.txtBusiName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre";
            // 
            // btnBusiAction
            // 
            this.btnBusiAction.BackColor = System.Drawing.Color.Black;
            this.btnBusiAction.ForeColor = System.Drawing.Color.Transparent;
            this.btnBusiAction.Location = new System.Drawing.Point(78, 261);
            this.btnBusiAction.Name = "btnBusiAction";
            this.btnBusiAction.Size = new System.Drawing.Size(87, 27);
            this.btnBusiAction.TabIndex = 16;
            this.btnBusiAction.Text = "Registrar";
            this.btnBusiAction.UseVisualStyleBackColor = false;
            this.btnBusiAction.Click += new System.EventHandler(this.btnBusiAction_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnProRefresh);
            this.tabPage4.Controls.Add(this.dgvPro);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(754, 324);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Productos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Seleccionar con doble click al registro para eliminarlo";
            // 
            // btnProRefresh
            // 
            this.btnProRefresh.Location = new System.Drawing.Point(426, 270);
            this.btnProRefresh.Name = "btnProRefresh";
            this.btnProRefresh.Size = new System.Drawing.Size(134, 27);
            this.btnProRefresh.TabIndex = 31;
            this.btnProRefresh.Text = "Refrescar Tabla";
            this.btnProRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Location = new System.Drawing.Point(282, 54);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.ReadOnly = true;
            this.dgvPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPro.Size = new System.Drawing.Size(400, 203);
            this.dgvPro.TabIndex = 30;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProAdd);
            this.groupBox4.Controls.Add(this.cmbProBusi);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtProName);
            this.groupBox4.Location = new System.Drawing.Point(7, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 159);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del producto";
            // 
            // btnProAdd
            // 
            this.btnProAdd.Location = new System.Drawing.Point(43, 114);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(134, 27);
            this.btnProAdd.TabIndex = 33;
            this.btnProAdd.Text = "Agregar";
            this.btnProAdd.UseVisualStyleBackColor = true;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click);
            // 
            // cmbProBusi
            // 
            this.cmbProBusi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProBusi.FormattingEnabled = true;
            this.cmbProBusi.Location = new System.Drawing.Point(65, 72);
            this.cmbProBusi.Name = "cmbProBusi";
            this.cmbProBusi.Size = new System.Drawing.Size(149, 23);
            this.cmbProBusi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Negocio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(65, 38);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(149, 23);
            this.txtProName.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(19, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 27);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Cerrar Sesión";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.BlueViolet;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 411F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 411);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ParcialPooReal.Properties.Resources.hugo;
            this.pictureBox2.Location = new System.Drawing.Point(89, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "frmAddUsers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmAddUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirections)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPro)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dtvUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chAdmin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDirectionRefresh;
        private System.Windows.Forms.DataGridView dgvDirections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDirectionAction;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBusiName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusiAction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBusiRefresh;
        private System.Windows.Forms.DataGridView dgvBusi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBusiCancel;
        private System.Windows.Forms.TextBox txtBusiDesc;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProRefresh;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.ComboBox cmbProBusi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}