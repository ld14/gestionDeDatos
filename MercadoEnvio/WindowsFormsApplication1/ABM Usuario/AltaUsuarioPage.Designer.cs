﻿namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class AltaUsuarioPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClienteGroup = new System.Windows.Forms.GroupBox();
            this.ClienteApellidoTxt = new System.Windows.Forms.TextBox();
            this.ClienteNombreTxt = new System.Windows.Forms.TextBox();
            this.ClienteFechaNacDateTime = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ClienteTipoDocComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ClienteDNITxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpresaGroup = new System.Windows.Forms.GroupBox();
            this.EmpresaFechaCreacionDateTime = new System.Windows.Forms.DateTimePicker();
            this.EmpresaNombreContactoTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpresaCuitTxt = new System.Windows.Forms.TextBox();
            this.EmpresaRazonSocialTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipoDeUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DatosBasicosCiudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DatosBasicosDepto = new System.Windows.Forms.TextBox();
            this.DatosBasicosPiso = new System.Windows.Forms.TextBox();
            this.DatosBasicosNroCalle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DatosBasicosCodigoPostal = new System.Windows.Forms.TextBox();
            this.DatosBasicosLocalidad = new System.Windows.Forms.TextBox();
            this.DatosBasicosDomicilioCalle = new System.Windows.Forms.TextBox();
            this.DatosBasicosTelefono = new System.Windows.Forms.TextBox();
            this.DatosBasicosEmailTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.userPasswordImput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Grabar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ClienteGroup.SuspendLayout();
            this.EmpresaGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.EmpresaGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tipoDeUsuarioComboBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.userPasswordImput);
            this.groupBox1.Controls.Add(this.userNameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClienteGroup);
            this.groupBox1.Location = new System.Drawing.Point(19, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Usuario";
            // 
            // ClienteGroup
            // 
            this.ClienteGroup.Controls.Add(this.ClienteApellidoTxt);
            this.ClienteGroup.Controls.Add(this.ClienteNombreTxt);
            this.ClienteGroup.Controls.Add(this.ClienteFechaNacDateTime);
            this.ClienteGroup.Controls.Add(this.label23);
            this.ClienteGroup.Controls.Add(this.label22);
            this.ClienteGroup.Controls.Add(this.label21);
            this.ClienteGroup.Controls.Add(this.ClienteTipoDocComboBox);
            this.ClienteGroup.Controls.Add(this.label20);
            this.ClienteGroup.Controls.Add(this.ClienteDNITxt);
            this.ClienteGroup.Controls.Add(this.label6);
            this.ClienteGroup.Location = new System.Drawing.Point(29, 139);
            this.ClienteGroup.Name = "ClienteGroup";
            this.ClienteGroup.Size = new System.Drawing.Size(484, 277);
            this.ClienteGroup.TabIndex = 11;
            this.ClienteGroup.TabStop = false;
            this.ClienteGroup.Text = "Datos Tipo Usuario";
            this.ClienteGroup.Visible = false;
            // 
            // ClienteApellidoTxt
            // 
            this.ClienteApellidoTxt.Location = new System.Drawing.Point(329, 94);
            this.ClienteApellidoTxt.Name = "ClienteApellidoTxt";
            this.ClienteApellidoTxt.Size = new System.Drawing.Size(126, 20);
            this.ClienteApellidoTxt.TabIndex = 41;
            // 
            // ClienteNombreTxt
            // 
            this.ClienteNombreTxt.Location = new System.Drawing.Point(129, 93);
            this.ClienteNombreTxt.Name = "ClienteNombreTxt";
            this.ClienteNombreTxt.Size = new System.Drawing.Size(126, 20);
            this.ClienteNombreTxt.TabIndex = 40;
            // 
            // ClienteFechaNacDateTime
            // 
            this.ClienteFechaNacDateTime.Location = new System.Drawing.Point(129, 125);
            this.ClienteFechaNacDateTime.Name = "ClienteFechaNacDateTime";
            this.ClienteFechaNacDateTime.Size = new System.Drawing.Size(326, 20);
            this.ClienteFechaNacDateTime.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(29, 126);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "Fecha Nacimiento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(267, 100);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Apellido";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Nombre";
            // 
            // ClienteTipoDocComboBox
            // 
            this.ClienteTipoDocComboBox.FormattingEnabled = true;
            this.ClienteTipoDocComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ClienteTipoDocComboBox.Location = new System.Drawing.Point(129, 61);
            this.ClienteTipoDocComboBox.Name = "ClienteTipoDocComboBox";
            this.ClienteTipoDocComboBox.Size = new System.Drawing.Size(126, 21);
            this.ClienteTipoDocComboBox.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Tipo Documento";
            // 
            // ClienteDNITxt
            // 
            this.ClienteDNITxt.Location = new System.Drawing.Point(329, 66);
            this.ClienteDNITxt.Name = "ClienteDNITxt";
            this.ClienteDNITxt.Size = new System.Drawing.Size(126, 20);
            this.ClienteDNITxt.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Numero";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EmpresaGroup
            // 
            this.EmpresaGroup.Controls.Add(this.EmpresaFechaCreacionDateTime);
            this.EmpresaGroup.Controls.Add(this.EmpresaNombreContactoTxt);
            this.EmpresaGroup.Controls.Add(this.label7);
            this.EmpresaGroup.Controls.Add(this.EmpresaCuitTxt);
            this.EmpresaGroup.Controls.Add(this.EmpresaRazonSocialTxt);
            this.EmpresaGroup.Controls.Add(this.label4);
            this.EmpresaGroup.Controls.Add(this.label5);
            this.EmpresaGroup.Controls.Add(this.label10);
            this.EmpresaGroup.Location = new System.Drawing.Point(30, 158);
            this.EmpresaGroup.Name = "EmpresaGroup";
            this.EmpresaGroup.Size = new System.Drawing.Size(484, 277);
            this.EmpresaGroup.TabIndex = 10;
            this.EmpresaGroup.TabStop = false;
            this.EmpresaGroup.Text = "Datos Tipo Usuario";
            this.EmpresaGroup.Visible = false;
            // 
            // EmpresaFechaCreacionDateTime
            // 
            this.EmpresaFechaCreacionDateTime.Location = new System.Drawing.Point(131, 132);
            this.EmpresaFechaCreacionDateTime.Name = "EmpresaFechaCreacionDateTime";
            this.EmpresaFechaCreacionDateTime.Size = new System.Drawing.Size(200, 20);
            this.EmpresaFechaCreacionDateTime.TabIndex = 53;
            // 
            // EmpresaNombreContactoTxt
            // 
            this.EmpresaNombreContactoTxt.Location = new System.Drawing.Point(131, 106);
            this.EmpresaNombreContactoTxt.Name = "EmpresaNombreContactoTxt";
            this.EmpresaNombreContactoTxt.Size = new System.Drawing.Size(126, 20);
            this.EmpresaNombreContactoTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre Contacto";
            // 
            // EmpresaCuitTxt
            // 
            this.EmpresaCuitTxt.Location = new System.Drawing.Point(131, 82);
            this.EmpresaCuitTxt.Name = "EmpresaCuitTxt";
            this.EmpresaCuitTxt.Size = new System.Drawing.Size(126, 20);
            this.EmpresaCuitTxt.TabIndex = 9;
            // 
            // EmpresaRazonSocialTxt
            // 
            this.EmpresaRazonSocialTxt.Location = new System.Drawing.Point(131, 58);
            this.EmpresaRazonSocialTxt.Name = "EmpresaRazonSocialTxt";
            this.EmpresaRazonSocialTxt.Size = new System.Drawing.Size(126, 20);
            this.EmpresaRazonSocialTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Razon social";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Fecha de Creación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de Usuario";
            // 
            // tipoDeUsuarioComboBox
            // 
            this.tipoDeUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDeUsuarioComboBox.FormattingEnabled = true;
            this.tipoDeUsuarioComboBox.Items.AddRange(new object[] {
            "Empresa",
            "Cliente"});
            this.tipoDeUsuarioComboBox.Location = new System.Drawing.Point(30, 110);
            this.tipoDeUsuarioComboBox.Name = "tipoDeUsuarioComboBox";
            this.tipoDeUsuarioComboBox.Size = new System.Drawing.Size(484, 21);
            this.tipoDeUsuarioComboBox.TabIndex = 12;
            this.tipoDeUsuarioComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.DatosBasicosCiudad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.DatosBasicosDepto);
            this.groupBox3.Controls.Add(this.DatosBasicosPiso);
            this.groupBox3.Controls.Add(this.DatosBasicosNroCalle);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.DatosBasicosCodigoPostal);
            this.groupBox3.Controls.Add(this.DatosBasicosLocalidad);
            this.groupBox3.Controls.Add(this.DatosBasicosDomicilioCalle);
            this.groupBox3.Controls.Add(this.DatosBasicosTelefono);
            this.groupBox3.Controls.Add(this.DatosBasicosEmailTxt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(561, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 390);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Básicos";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // DatosBasicosCiudad
            // 
            this.DatosBasicosCiudad.Location = new System.Drawing.Point(147, 267);
            this.DatosBasicosCiudad.Name = "DatosBasicosCiudad";
            this.DatosBasicosCiudad.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosCiudad.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ciudad";
            this.label8.Click += new System.EventHandler(this.label18_Click);
            // 
            // DatosBasicosDepto
            // 
            this.DatosBasicosDepto.Location = new System.Drawing.Point(147, 177);
            this.DatosBasicosDepto.Name = "DatosBasicosDepto";
            this.DatosBasicosDepto.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosDepto.TabIndex = 47;
            // 
            // DatosBasicosPiso
            // 
            this.DatosBasicosPiso.Location = new System.Drawing.Point(147, 148);
            this.DatosBasicosPiso.Name = "DatosBasicosPiso";
            this.DatosBasicosPiso.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosPiso.TabIndex = 46;
            // 
            // DatosBasicosNroCalle
            // 
            this.DatosBasicosNroCalle.Location = new System.Drawing.Point(147, 119);
            this.DatosBasicosNroCalle.Name = "DatosBasicosNroCalle";
            this.DatosBasicosNroCalle.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosNroCalle.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Localidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Departamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Piso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Nro calle";
            // 
            // DatosBasicosCodigoPostal
            // 
            this.DatosBasicosCodigoPostal.Location = new System.Drawing.Point(147, 235);
            this.DatosBasicosCodigoPostal.Name = "DatosBasicosCodigoPostal";
            this.DatosBasicosCodigoPostal.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosCodigoPostal.TabIndex = 39;
            // 
            // DatosBasicosLocalidad
            // 
            this.DatosBasicosLocalidad.Location = new System.Drawing.Point(147, 206);
            this.DatosBasicosLocalidad.Name = "DatosBasicosLocalidad";
            this.DatosBasicosLocalidad.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosLocalidad.TabIndex = 38;
            // 
            // DatosBasicosDomicilioCalle
            // 
            this.DatosBasicosDomicilioCalle.Location = new System.Drawing.Point(147, 90);
            this.DatosBasicosDomicilioCalle.Name = "DatosBasicosDomicilioCalle";
            this.DatosBasicosDomicilioCalle.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosDomicilioCalle.TabIndex = 37;
            // 
            // DatosBasicosTelefono
            // 
            this.DatosBasicosTelefono.Location = new System.Drawing.Point(147, 61);
            this.DatosBasicosTelefono.Name = "DatosBasicosTelefono";
            this.DatosBasicosTelefono.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosTelefono.TabIndex = 36;
            // 
            // DatosBasicosEmailTxt
            // 
            this.DatosBasicosEmailTxt.Location = new System.Drawing.Point(147, 33);
            this.DatosBasicosEmailTxt.Name = "DatosBasicosEmailTxt";
            this.DatosBasicosEmailTxt.Size = new System.Drawing.Size(208, 20);
            this.DatosBasicosEmailTxt.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Código Postal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Domicilio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Telefono";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Mail";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // userPasswordImput
            // 
            this.userPasswordImput.Location = new System.Drawing.Point(320, 47);
            this.userPasswordImput.Name = "userPasswordImput";
            this.userPasswordImput.Size = new System.Drawing.Size(194, 20);
            this.userPasswordImput.TabIndex = 8;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(30, 46);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(257, 20);
            this.userNameInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Grabar);
            this.groupBox2.Location = new System.Drawing.Point(19, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Grabar
            // 
            this.Grabar.Location = new System.Drawing.Point(406, 46);
            this.Grabar.Name = "Grabar";
            this.Grabar.Size = new System.Drawing.Size(222, 23);
            this.Grabar.TabIndex = 0;
            this.Grabar.Text = "Crear Usuario";
            this.Grabar.UseVisualStyleBackColor = true;
            this.Grabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(293, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(520, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 18);
            this.label19.TabIndex = 30;
            this.label19.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(361, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 18);
            this.label24.TabIndex = 31;
            this.label24.Text = "*";
            // 
            // AltaUsuarioPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaUsuarioPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ClienteGroup.ResumeLayout(false);
            this.ClienteGroup.PerformLayout();
            this.EmpresaGroup.ResumeLayout(false);
            this.EmpresaGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox userPasswordImput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipoDeUsuarioComboBox;
        private System.Windows.Forms.Button Grabar;
        private System.Windows.Forms.TextBox DatosBasicosDepto;
        private System.Windows.Forms.TextBox DatosBasicosPiso;
        private System.Windows.Forms.TextBox DatosBasicosNroCalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DatosBasicosCodigoPostal;
        private System.Windows.Forms.TextBox DatosBasicosLocalidad;
        private System.Windows.Forms.TextBox DatosBasicosDomicilioCalle;
        private System.Windows.Forms.TextBox DatosBasicosTelefono;
        private System.Windows.Forms.TextBox DatosBasicosEmailTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox EmpresaGroup;
        private System.Windows.Forms.TextBox EmpresaCuitTxt;
        private System.Windows.Forms.TextBox EmpresaRazonSocialTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpresaNombreContactoTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DatosBasicosCiudad;
        private System.Windows.Forms.DateTimePicker EmpresaFechaCreacionDateTime;
        private System.Windows.Forms.GroupBox ClienteGroup;
        private System.Windows.Forms.TextBox ClienteApellidoTxt;
        private System.Windows.Forms.TextBox ClienteNombreTxt;
        private System.Windows.Forms.DateTimePicker ClienteFechaNacDateTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox ClienteTipoDocComboBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ClienteDNITxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label24;
    }
}