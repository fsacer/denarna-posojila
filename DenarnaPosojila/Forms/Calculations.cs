using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DenarnaPosojila.Data;
using System.Collections.Generic;

namespace DenarnaPosojila.Forms
{
    public partial class Calculations : Form
    {
        private PosojilaDataSet db = DBHandle.db;
        private decimal total = 0, loaned = 0, lended = 0, diff = 0, toRefund = 0, toGetRefunded = 0, debt = 0;

        public Calculations()
        {
            InitializeComponent();
        }
        private decimal CalculationMechanizm(IEnumerable<PosojilaDataSet.PosojilaRow> query) 
        {
            decimal result = 0;
            foreach (var p in query)
            {
                foreach (var v in db.Valute)
                {
                    if (p.Valuta == v.Kratica)
                    {
                        var calc = p.Znesek;
                        if (!v.Privzeto == true)
                        {
                            calc = calc / v.TecajVEUR;
                            calc = Math.Round(calc, 2);
                        }
                        result = decimal.Add(result, calc);
                    }
                }
            }
            return result;
        }
        private void CalculateTotal()
        {
            total = CalculationMechanizm(db.Posojila);
            txtSkupaj.Text = total.ToString();
        }
        private void CalculateTotalLoaned()
        {
            var query = (from p in db.Posojila where p.Izposojevalec == Program.IDUporabnika select p).ToList();
            loaned = CalculationMechanizm(query);
            txtIzposojeno.Text = loaned.ToString();
        }
        private void CalculateTotalLended()
        {
            var query = (from p in db.Posojila where p.Posojevalec == Program.IDUporabnika select p).ToList();
            lended = CalculationMechanizm(query);
            txtPosojeno.Text = lended.ToString();
        }
        private void CalculateDiff() {
            diff = Math.Abs(lended - loaned);
            txtRazlika.Text = diff.ToString();
        }
        private void ToRefund() 
        {
            var query = (from p in db.Posojila where p.Izposojevalec == Program.IDUporabnika && p.Vrnjeno == false select p).ToList();
            toRefund = CalculationMechanizm(query);
            txtZaVrniti.Text = toRefund.ToString();
        }
        private void ToGetRefunded()
        {
            var query = (from p in db.Posojila where p.Posojevalec == Program.IDUporabnika && p.Vrnjeno == false select p).ToList();
            toGetRefunded = CalculationMechanizm(query);
            txtDobitiVrnjeno.Text = toGetRefunded.ToString();
        }

        private void CalculateDebt()
        {
            debt = Math.Abs(toGetRefunded - toRefund);
            txtDolg.Text = debt.ToString();
        }
        private void AllCalculations() {
            CalculateTotal();
            CalculateTotalLoaned();
            CalculateTotalLended();
            CalculateDiff();
            ToRefund();
            ToGetRefunded();
            CalculateDebt();
        }

        private void Calculations_Load(object sender, EventArgs e)
        {
            AllCalculations();
        }
    }
}
