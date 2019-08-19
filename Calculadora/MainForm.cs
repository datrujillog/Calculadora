/*
 * Created by SharpDevelop.
 * User: AORUS
 * Date: 17/04/2018
 * Time: 21:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Calculadora
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double primero;
		double segundo;
		double resultado;
		string operacion;
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
		
			//		Console.WriteLine("Hello World");
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CAJACheckedChanged(object sender, EventArgs e)
		{
	    	
		
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button4Click(object sender, EventArgs e)
		{
	
		}
		void Btn0Click(object sender, EventArgs e)
		{
			Pantalla.Text = Pantalla.Text +"0";
		}
		void Btn1Click(object sender, EventArgs e)
		{
			Pantalla.Text = Pantalla.Text +"1";
	      
		}
		void Btn2Click(object sender, EventArgs e)
		{
	        Pantalla.Text = Pantalla.Text +"2"; 
		}
		void Btn3Click(object sender, EventArgs e)
		{
	       Pantalla.Text = Pantalla.Text +"3";
		}
		void Btn4Click(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +"4";
		}
		void Btn5Click(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +"5";
		}
		void Btn6Click(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +"6";
		}
		void Btn7Click(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +"7";
		}
		void Btn8Click(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +"8";
		}
		void Btn9Click(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +"9";
		}
		void BtnpuntoClick(object sender, EventArgs e)
		{
	Pantalla.Text = Pantalla.Text +".";
		}
		void BtnsumaClick(object sender, EventArgs e)
		{
			operacion="+";
			primero=double.Parse(Pantalla.Text);
			Pantalla.Clear();
		}
		void BtnrestaClick(object sender, EventArgs e)
		{
	operacion="-";
			primero=double.Parse(Pantalla.Text);
			Pantalla.Clear();
		}
		void BtnmultiplicacionClick(object sender, EventArgs e)
		{
	operacion="*";
			primero=double.Parse(Pantalla.Text);
			Pantalla.Clear();
		}
		void BtndivisionClick(object sender, EventArgs e)
		{
	operacion="/";
			primero=double.Parse(Pantalla.Text);
			Pantalla.Clear();
		}
		void BtnigualClick(object sender, EventArgs e)
		{
			segundo=double.Parse(Pantalla.Text);
			
			switch(operacion){
				case "+":
					resultado=primero+segundo;
					Pantalla.Text=resultado.ToString();
					break;
				case "-":
					resultado=primero-segundo;
					Pantalla.Text=resultado.ToString();
					break;
			case "*":
					resultado=primero*segundo;
					Pantalla.Text=resultado.ToString();
					break;
			case "/":
					resultado=primero/segundo;
					Pantalla.Text=resultado.ToString();
					break;
			
			}
		}
		void BtnlimpiarClick(object sender, EventArgs e)
		{
			Pantalla.Clear();
		}
		void BtnraizClick(object sender, EventArgs e)
		{
			operacion="raiz";
			primero=double.Parse(Pantalla.Text);
			resultado=primero;
			Pantalla.Text=Math.Sqrt(primero).ToString();
		}
		void BtncuadradoClick(object sender, EventArgs e)
		{
			operacion="cuadrado";
			primero=double.Parse(Pantalla.Text);
			resultado=primero;
			Pantalla.Text=Math.Pow(primero,2).ToString();
		}
		void BtnnegacionClick(object sender, EventArgs e)
		{
	       operacion="±";
			primero=double.Parse(Pantalla.Text);
			Pantalla.Clear();
	
		}
	}
}
