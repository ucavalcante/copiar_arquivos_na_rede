using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;


namespace CopiarArquivosNaRede.Sistema
{
    class GerirTabela
    {
        public DataTable tabelaDeMaquinas()
        {
            DataTable dt1 = new DataTable();
           
            string arquivo = @".\CAR-config.xml";

            DataSet oDataSet = new DataSet();
            oDataSet.ReadXml(arquivo);

            dt1 = oDataSet.Tables[0];
            return dt1;
            
        }

        public string[] SetoresArray()
        {

            DataTable dt = tabelaDeMaquinas();
            

            string[] resultArray = new string[dt.Rows.Count];
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    resultArray[row] = dt.Rows[row][1].ToString();
                }
            }

            string[] distinct = resultArray.Distinct().ToArray();

            Array.Sort(distinct);
            return distinct;
        }

        public string[] MaquinasArray(DataTable dt)
        {

           //dt = tabelaDeMaquinas();
            try
            {
                string[] resultArray = new string[dt.Rows.Count];
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        resultArray[row] = dt.Rows[row][0].ToString();
                    }
                }

                string[] distinct = resultArray.Distinct().ToArray();

                Array.Sort(distinct);
                return distinct;
            }
            catch (NullReferenceException)
            {
                dt = tabelaDeMaquinas();
                string[] resultArray = new string[dt.Rows.Count];
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        resultArray[row] = dt.Rows[row][0].ToString();
                    }
                }

                string[] distinct = resultArray.Distinct().ToArray();

                return distinct;
            }
            
        }

        public DataTable MaquinasNosSetores(string[] SetoresSelecionados)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = tabelaDeMaquinas();
                ArrayList paramArray = new ArrayList();
                string where = "";
                for (int i = 0; i < SetoresSelecionados.Length; i++)
                {
                    paramArray.Add("Setor like '");
                    paramArray.Add(SetoresSelecionados[i] + "'");
                    paramArray.Add(" or ");
                }
                paramArray.RemoveAt(paramArray.Count - 1);

                for (int i = 0; i < paramArray.Count; i++)
                {
                    where = where + paramArray[i];
                }

                DataRow[] dr = dt.Select(where);
                dt = dr.CopyToDataTable();
                DataTable view = dt.DefaultView.ToTable(true, "CPU");
                return view;

                
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
                //return tabelaDeMaquinas();
            }
            catch (InvalidOperationException)
            {
                return null;
                //return tabelaDeMaquinas();
            }
            
        }
    }
}
