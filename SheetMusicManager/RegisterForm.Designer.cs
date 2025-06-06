﻿namespace SheetMusicManager
{
    partial class RegisterForm
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
            lblContrasena = new Label();
            panelRegister = new Panel();
            lblFuerza = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelCorreo = new Panel();
            pictureBox5 = new PictureBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            lblIniciarS = new Label();
            btnRegister = new Button();
            panelPassword = new Panel();
            pictureBoxPass = new PictureBox();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            panelUsuario = new Panel();
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            pictureBox6 = new PictureBox();
            panelRegister.SuspendLayout();
            panelCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(12, 11);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(118, 28);
            lblContrasena.TabIndex = 0;
            lblContrasena.Text = "Contraseña";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.Azure;
            panelRegister.Controls.Add(lblFuerza);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(panelCorreo);
            panelRegister.Controls.Add(pictureBox4);
            panelRegister.Controls.Add(lblIniciarS);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(panelPassword);
            panelRegister.Controls.Add(panelUsuario);
            panelRegister.Location = new Point(346, 79);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(596, 814);
            panelRegister.TabIndex = 2;
            // 
            // lblFuerza
            // 
            lblFuerza.AutoSize = true;
            lblFuerza.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuerza.Location = new Point(355, 506);
            lblFuerza.Name = "lblFuerza";
            lblFuerza.Size = new Size(132, 28);
            lblFuerza.TabIndex = 14;
            lblFuerza.Text = "Débil/Fuerte";
            lblFuerza.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 726);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 6;
            label2.Text = "Ya tienes cuenta?";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 543);
            label3.Name = "label3";
            label3.Size = new Size(385, 87);
            label3.TabIndex = 13;
            label3.Text = "La contraseña debe tener al menos 8 caracteres, incluir una letra mayúscula, una minúscula, un número y un símbolo.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 506);
            label4.Name = "label4";
            label4.Size = new Size(241, 28);
            label4.TabIndex = 12;
            label4.Text = "Fuerza de la contraseña:";
            // 
            // panelCorreo
            // 
            panelCorreo.BackColor = Color.White;
            panelCorreo.Controls.Add(pictureBox5);
            panelCorreo.Controls.Add(txtCorreo);
            panelCorreo.Controls.Add(label1);
            panelCorreo.Location = new Point(119, 284);
            panelCorreo.Name = "panelCorreo";
            panelCorreo.Size = new Size(385, 90);
            panelCorreo.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.email;
            pictureBox5.Location = new Point(12, 42);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(49, 45);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(300, 24);
            txtCorreo.TabIndex = 1;
            txtCorreo.Text = "Correo Electrónico";
            txtCorreo.Click += txtCorreo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Correo";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(162, -39);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(259, 201);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // lblIniciarS
            // 
            lblIniciarS.AutoSize = true;
            lblIniciarS.Cursor = Cursors.Hand;
            lblIniciarS.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIniciarS.ForeColor = Color.MediumBlue;
            lblIniciarS.Location = new Point(62, 757);
            lblIniciarS.Name = "lblIniciarS";
            lblIniciarS.Size = new Size(100, 21);
            lblIniciarS.TabIndex = 3;
            lblIniciarS.Text = "Iniciar sesión";
            lblIniciarS.Click += lblIniciarS_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(61, 76, 158);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(117, 647);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(387, 56);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(pictureBoxPass);
            panelPassword.Controls.Add(pictureBox2);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(lblContrasena);
            panelPassword.Location = new Point(119, 400);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(385, 90);
            panelPassword.TabIndex = 1;
            // 
            // pictureBoxPass
            // 
            pictureBoxPass.Cursor = Cursors.Hand;
            pictureBoxPass.Image = Properties.Resources.visible__1_;
            pictureBoxPass.Location = new Point(318, 42);
            pictureBoxPass.Name = "pictureBoxPass";
            pictureBoxPass.Size = new Size(31, 31);
            pictureBoxPass.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPass.TabIndex = 2;
            pictureBoxPass.TabStop = false;
            pictureBoxPass.MouseDown += pictureBoxPass_MouseDown;
            pictureBoxPass.MouseUp += pictureBoxPass_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password2__1_;
            pictureBox2.Location = new Point(12, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(49, 47);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 24);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "*********";
            txtPassword.Click += txtPassword_Click;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.White;
            panelUsuario.Controls.Add(pictureBox1);
            panelUsuario.Controls.Add(txtUsuario);
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Location = new Point(119, 168);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(385, 90);
            panelUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(49, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 24);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            txtUsuario.Click += txtUsuario_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 11);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 28);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.close;
            pictureBox6.Location = new Point(1207, 25);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 226, 243);
            ClientSize = new Size(1281, 969);
            Controls.Add(pictureBox6);
            Controls.Add(panelRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            MouseDown += RegisterForm_MouseDown;
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panelCorreo.ResumeLayout(false);
            panelCorreo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblContrasena;
        private Panel panelRegister;
        private PictureBox pictureBox4;
        private Label lblIniciarS;
        private Button btnRegister;
        private Panel panelPassword;
        private PictureBox pictureBoxPass;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private Panel panelUsuario;
        private PictureBox pictureBox1;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Panel panelCorreo;
        private PictureBox pictureBox5;
        private TextBox txtCorreo;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox6;
        private Label lblFuerza;
        private Label label3;
        private Label label4;
    }
}