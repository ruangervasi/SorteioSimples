﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Util;
using System.Drawing;
using Android.Graphics.Drawables;

namespace SorteioSimples
{
    [Activity(Label = "Sorteio Simples", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnSortear= FindViewById<Button>(Resource.Id.Sortear);
            EditText Numero = FindViewById<EditText>(Resource.Id.MaiorNumero);
            TextView resultado = FindViewById<TextView>(Resource.Id.ResultadoSorteio);

            btnSortear.Click += delegate { resultado.Text = Sortear(Numero.Text); };
        }

        public string Sortear(string numero)
        {
            TextView Messeger = FindViewById<TextView>(Resource.Id.Messeger);
            if (numero != "")
            { 
            System.Random rdn = new System.Random();

            string strNumeroaleatorio;

            strNumeroaleatorio = rdn.Next(0,Convert.ToInt32(numero) + 1).ToString();
            Messeger.Text = "O ganhador é o numero: ";
                
                return strNumeroaleatorio;
            }
            else
            {
                Messeger.Text = "Insira um numero correto!!!";
                return "";
            }
        }
    }
}

