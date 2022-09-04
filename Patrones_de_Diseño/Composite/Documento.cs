﻿/*
 * Created by SharpDevelop.
 * User: Waldo
 * Date: 09/04/2019
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Patrones_de_Diseño.Composite
{

	abstract public class Documento
	{
		private string titulo;
		public Documento(string t)
		{
			titulo = t;
		}
		
		virtual public void leer(string filename){
			Console.WriteLine("Leyendo de " + filename);
			titulo = Console.ReadLine();
		}
		
		virtual public void escribir(string filename){
			Console.WriteLine("Escribiendo en " + filename);
			Console.WriteLine(titulo);
		}
		
		virtual public void imprimir(string impresora){
			Console.WriteLine("Imprimiendo en " + impresora);
			Console.WriteLine(titulo);
		}
	}
	
	public class DocumentoCompuesto : Documento {
		private List<Documento> hijos;
		
		public DocumentoCompuesto(string t) : base (t)
		{
			hijos = new List<Documento>();
		}
		
		public void agregarHijo(Documento d){
			hijos.Add(d);
		}
		
		override public void leer(string filename){
			foreach (Documento d in hijos) {
				d.leer(filename);
			}
		}
		
		override public void escribir(string filename){
			foreach (Documento d in hijos) {
				d.escribir(filename);
			}
		}
		
		override public void imprimir(string impresora){
			foreach (Documento d in hijos) {
				d.imprimir(impresora);
			}
		}
	}
	
	public class Texto : Documento{
		private string texto;
		
		public Texto(string t) : base("")	{
			texto = t;
		}
		
		override public void leer(string filename){
			base.leer(filename);
			Console.WriteLine("Leyendo texto de " + filename);
			texto = Console.ReadLine();
		}
		
		override public void escribir(string filename){
			base.escribir(filename);
			Console.WriteLine("Escribiendo texto en " + filename);
			Console.WriteLine(texto);
		}
		
		override public void imprimir(string impresora){
			base.imprimir(impresora);
			Console.WriteLine("Imprimiendo texto en " + impresora);
			Console.WriteLine(texto);
		}
	}
	
	public class Figura : Documento{
		private string figura;
		
		public Figura(string f) : base("")	{
			figura = f;
		}
		
		override public void leer(string filename){
			base.leer(filename);
			Console.WriteLine("Leyendo figura de " + filename);
			figura = Console.ReadLine();
		}
		
		override public void escribir(string filename){
			base.escribir(filename);
			Console.WriteLine("Escribiendo figura en " + filename);
			Console.WriteLine(figura);
		}
		
		override public void imprimir(string impresora){
			base.imprimir(impresora);
			Console.WriteLine("Imprimiendo figura en " + impresora);
			Console.WriteLine(figura);
		}
	}
	
	public class Program{
		
		private static Documento crearDocumento(){
			Texto d111 = new Texto("Algo que decir");
			Figura d112 = new Figura("Algo que mostrar");
			
			DocumentoCompuesto d11 = new DocumentoCompuesto("Sección 1.1");
			d11.agregarHijo(d111);
			d11.agregarHijo(d112);
			
			Texto d12 = new Texto("Algún texto");
			Figura d13 = new Figura("Alguna figura");
			
			Texto d21 = new Texto("Otro texto");
			Figura d22 = new Figura("Otra figura");
			
			DocumentoCompuesto d1 = new DocumentoCompuesto("Sección 1");
			d1.agregarHijo(d11);
			d1.agregarHijo(d12);
			d1.agregarHijo(d13);
			
			DocumentoCompuesto d2 = new DocumentoCompuesto("Sección 2");
			d2.agregarHijo(d21);
			d2.agregarHijo(d22);
			
			DocumentoCompuesto d = new DocumentoCompuesto("Documento principal");
			d.agregarHijo(d1);
			d.agregarHijo(d2);
			
			return d;
		}
		
		public static void Main(string[] args)	{
			Documento d = crearDocumento();
			
			d.leer("archivo.txt");
			d.escribir("archivo.txt");
			d.imprimir("impresora");
			
			Console.Write("Programa finalizado correctamente.");
			Console.ReadKey(true);
		}
	}
}
