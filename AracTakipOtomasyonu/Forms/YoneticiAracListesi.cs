﻿using BusinessLayer.Repositories;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakipOtomasyonu.Forms
{
    public partial class YoneticiAracListesi : Form
    {
        public List<Araclar> araclar;

        public YoneticiAracListesi()
        {
            InitializeComponent();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            AraclarRepository arac = new AraclarRepository();
            araclar = arac.TumVeriyiGetir();
            for (int i = 0; i < araclar.Count; i++)
            {
                dt_AracListele.DataSource = araclar;
            }
           
        }
    }
}
