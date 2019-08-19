/*
 * Created by SharpDevelop.
 * User: AORUS
 * Date: 17/04/2018
 * Time: 21:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox Pantalla;
		private System.Windows.Forms.Button btnlimpiar;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btnsuma;
		private System.Windows.Forms.Button btndec;
		private System.Windows.Forms.Button btnmultiplicacion;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btndivision;
		private System.Windows.Forms.Button btnigual;
		private System.Windows.Forms.Button btnpunto;
		private System.Windows.Forms.Button btnresta;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btnnegacion;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btnc;
		private System.Windows.Forms.Button btnraiz;
		private System.Windows.Forms.Button btncuadrado;
		private System.Windows.Forms.Button btnretro;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Pantalla = new System.Windows.Forms.TextBox();
			this.btnlimpiar = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btnsuma = new System.Windows.Forms.Button();
			this.btndec = new System.Windows.Forms.Button();
			this.btnmultiplicacion = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btndivision = new System.Windows.Forms.Button();
			this.btnigual = new System.Windows.Forms.Button();
			this.btnpunto = new System.Windows.Forms.Button();
			this.btnresta = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btnnegacion = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnc = new System.Windows.Forms.Button();
			this.btnraiz = new System.Windows.Forms.Button();
			this.btncuadrado = new System.Windows.Forms.Button();
			this.btnretro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Pantalla
			// 
			this.Pantalla.Location = new System.Drawing.Point(32, 20);
			this.Pantalla.Name = "Pantalla";
			this.Pantalla.ReadOnly = true;
			this.Pantalla.Size = new System.Drawing.Size(214, 20);
			this.Pantalla.TabIndex = 0;
			this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Pantalla.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// btnlimpiar
			// 
			this.btnlimpiar.Location = new System.Drawing.Point(197, 46);
			this.btnlimpiar.Name = "btnlimpiar";
			this.btnlimpiar.Size = new System.Drawing.Size(49, 23);
			this.btnlimpiar.TabIndex = 1;
			this.btnlimpiar.Text = "CE";
			this.btnlimpiar.UseVisualStyleBackColor = true;
			this.btnlimpiar.Click += new System.EventHandler(this.BtnlimpiarClick);
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(32, 162);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(49, 23);
			this.btn4.TabIndex = 2;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(87, 162);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(49, 23);
			this.btn5.TabIndex = 3;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btnsuma
			// 
			this.btnsuma.Location = new System.Drawing.Point(197, 191);
			this.btnsuma.Name = "btnsuma";
			this.btnsuma.Size = new System.Drawing.Size(49, 23);
			this.btnsuma.TabIndex = 4;
			this.btnsuma.Text = "+";
			this.btnsuma.UseVisualStyleBackColor = true;
			this.btnsuma.Click += new System.EventHandler(this.BtnsumaClick);
			// 
			// btndec
			// 
			this.btndec.Location = new System.Drawing.Point(197, 75);
			this.btndec.Name = "btndec";
			this.btndec.Size = new System.Drawing.Size(49, 23);
			this.btndec.TabIndex = 5;
			this.btndec.Text = "1/x";
			this.btndec.UseVisualStyleBackColor = true;
			this.btndec.Click += new System.EventHandler(this.Button4Click);
			// 
			// btnmultiplicacion
			// 
			this.btnmultiplicacion.Location = new System.Drawing.Point(197, 133);
			this.btnmultiplicacion.Name = "btnmultiplicacion";
			this.btnmultiplicacion.Size = new System.Drawing.Size(49, 23);
			this.btnmultiplicacion.TabIndex = 6;
			this.btnmultiplicacion.Text = "*";
			this.btnmultiplicacion.UseVisualStyleBackColor = true;
			this.btnmultiplicacion.Click += new System.EventHandler(this.BtnmultiplicacionClick);
			// 
			// btn9
			// 
			this.btn9.Location = new System.Drawing.Point(142, 133);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(49, 23);
			this.btn9.TabIndex = 7;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// btn8
			// 
			this.btn8.Location = new System.Drawing.Point(87, 133);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(49, 23);
			this.btn8.TabIndex = 8;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn7
			// 
			this.btn7.Location = new System.Drawing.Point(32, 133);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(49, 23);
			this.btn7.TabIndex = 9;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btndivision
			// 
			this.btndivision.Location = new System.Drawing.Point(197, 104);
			this.btndivision.Name = "btndivision";
			this.btndivision.Size = new System.Drawing.Size(49, 23);
			this.btndivision.TabIndex = 10;
			this.btndivision.Text = "÷";
			this.btndivision.UseVisualStyleBackColor = true;
			this.btndivision.Click += new System.EventHandler(this.BtndivisionClick);
			// 
			// btnigual
			// 
			this.btnigual.Location = new System.Drawing.Point(197, 220);
			this.btnigual.Name = "btnigual";
			this.btnigual.Size = new System.Drawing.Size(49, 23);
			this.btnigual.TabIndex = 13;
			this.btnigual.Text = "=";
			this.btnigual.UseVisualStyleBackColor = true;
			this.btnigual.Click += new System.EventHandler(this.BtnigualClick);
			// 
			// btnpunto
			// 
			this.btnpunto.Location = new System.Drawing.Point(142, 220);
			this.btnpunto.Name = "btnpunto";
			this.btnpunto.Size = new System.Drawing.Size(49, 23);
			this.btnpunto.TabIndex = 12;
			this.btnpunto.Text = ".";
			this.btnpunto.UseVisualStyleBackColor = true;
			this.btnpunto.Click += new System.EventHandler(this.BtnpuntoClick);
			// 
			// btnresta
			// 
			this.btnresta.Location = new System.Drawing.Point(197, 162);
			this.btnresta.Name = "btnresta";
			this.btnresta.Size = new System.Drawing.Size(49, 23);
			this.btnresta.TabIndex = 11;
			this.btnresta.Text = "-";
			this.btnresta.UseVisualStyleBackColor = true;
			this.btnresta.Click += new System.EventHandler(this.BtnrestaClick);
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(142, 162);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(49, 23);
			this.btn6.TabIndex = 16;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(142, 191);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(49, 23);
			this.btn3.TabIndex = 15;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn0
			// 
			this.btn0.Location = new System.Drawing.Point(87, 220);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(49, 23);
			this.btn0.TabIndex = 14;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.Btn0Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(87, 191);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(49, 23);
			this.btn2.TabIndex = 19;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btnnegacion
			// 
			this.btnnegacion.Location = new System.Drawing.Point(32, 220);
			this.btnnegacion.Name = "btnnegacion";
			this.btnnegacion.Size = new System.Drawing.Size(49, 23);
			this.btnnegacion.TabIndex = 18;
			this.btnnegacion.Text = "±";
			this.btnnegacion.UseVisualStyleBackColor = true;
			this.btnnegacion.Click += new System.EventHandler(this.BtnnegacionClick);
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(32, 191);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(49, 23);
			this.btn1.TabIndex = 17;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btnc
			// 
			this.btnc.Location = new System.Drawing.Point(32, 79);
			this.btnc.Name = "btnc";
			this.btnc.Size = new System.Drawing.Size(49, 23);
			this.btnc.TabIndex = 22;
			this.btnc.Text = "C";
			this.btnc.UseVisualStyleBackColor = true;
			// 
			// btnraiz
			// 
			this.btnraiz.Location = new System.Drawing.Point(87, 104);
			this.btnraiz.Name = "btnraiz";
			this.btnraiz.Size = new System.Drawing.Size(49, 23);
			this.btnraiz.TabIndex = 24;
			this.btnraiz.Text = "Raiz";
			this.btnraiz.UseVisualStyleBackColor = true;
			this.btnraiz.Click += new System.EventHandler(this.BtnraizClick);
			// 
			// btncuadrado
			// 
			this.btncuadrado.Location = new System.Drawing.Point(142, 104);
			this.btncuadrado.Name = "btncuadrado";
			this.btncuadrado.Size = new System.Drawing.Size(49, 23);
			this.btncuadrado.TabIndex = 25;
			this.btncuadrado.Text = "x^2";
			this.btncuadrado.UseVisualStyleBackColor = true;
			this.btncuadrado.Click += new System.EventHandler(this.BtncuadradoClick);
			// 
			// btnretro
			// 
			this.btnretro.Location = new System.Drawing.Point(142, 46);
			this.btnretro.Name = "btnretro";
			this.btnretro.Size = new System.Drawing.Size(49, 23);
			this.btnretro.TabIndex = 26;
			this.btnretro.Text = "«";
			this.btnretro.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 276);
			this.Controls.Add(this.btnretro);
			this.Controls.Add(this.btncuadrado);
			this.Controls.Add(this.btnraiz);
			this.Controls.Add(this.btnc);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btnnegacion);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btnigual);
			this.Controls.Add(this.btnpunto);
			this.Controls.Add(this.btnresta);
			this.Controls.Add(this.btndivision);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btnmultiplicacion);
			this.Controls.Add(this.btndec);
			this.Controls.Add(this.btnsuma);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btnlimpiar);
			this.Controls.Add(this.Pantalla);
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
