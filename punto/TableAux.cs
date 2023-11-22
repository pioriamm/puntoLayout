using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto
{
    public class TableAux
    {
        public string Bandeiras(String valor) {

            Dictionary<string, string> bandeiras = new Dictionary<string, string> {

                {"001", "Master" },
                {"002", "Visa" },
                {"022", "Elo" },
                {"024", "Amex" },
                {"033", "Hipercard" },
                {"036", "Cabal" },
            
            };

            foreach (KeyValuePair < string,string> mapa in bandeiras) 
            {

                if (mapa.Key.Equals(valor)) {
                    return mapa.Value;
                }
            }
            return valor;
            

        }
        public string lancamento(String valor) {


            Dictionary<string, string> lancamento = new Dictionary<string, string> 
            {
                {"0", "Previsao" },
                {"1", "Liquidacao Normal" },
                {"2", "Liquidacao Antecipada" },
                {"3", "Saldo de Antecipacao Parcial" },
                        
            };

            foreach (KeyValuePair < string,string> mapa in lancamento) 
            {

                if (mapa.Key.Equals(valor)) {
                    return mapa.Value;
                }
            }
            return valor;
            

        }
        public string modalidade_transacao(String valor) {

            Dictionary<string, string> modalidadeTransacao = new Dictionary<string, string>() {

                {"c", "Credito" },
                {"d", "Debito" },
                {"v", "Voucher" },
                {"p", "PIX" },
            
            };

            foreach (KeyValuePair < string,string> mapa in modalidadeTransacao) 
            {

                if (mapa.Key.Equals(valor)) {
                    return mapa.Value;
                }
            }
            return valor;
            

        }
        public string tipoAjuste(String valor)
        {

            Dictionary<string, string> ajustes = new Dictionary<string, string> {

                {"1", "Ajuste a Credito" },
                {"2", "Ajuste a Debito" },

            };

            foreach (KeyValuePair<string, string> mapa in ajustes)
            {

                if (mapa.Key.Equals(valor))
                {
                    return mapa.Value;
                }
            }
            return valor;


        }
        public string origem_transacao(String valor)
        {

            Dictionary<string, string> origemtransacao = new Dictionary<string, string>()
            {

                {"00", "Normal" },
                {"01", "DCC(Conversor de Moedas)" },
                {"02", "Plus Price" },
                {"03", "Taxa + Tarifa" },
                {"04", "E-commerce" },

            };

            foreach (KeyValuePair<string, string> mapa in origemtransacao)
            {

                if (mapa.Key.Equals(valor))
                {
                    return mapa.Value;
                }
            }
            return valor;


        }
        public string meio_captura(String valor) {

            Dictionary<string, string> meioCaptura = new Dictionary<string, string>(){

                {"1", "Manual" },
                {"2", "POS (Point of Sale)" },
                {"3", "TEF" },
                {"4", "Digitada" },
                {"5", "Internet" },
                {"6", "URA" },
                {"8", "Indefinido" },
                {"9", "Outros" },

            };

            foreach (KeyValuePair < string,string> mapa in meioCaptura) 
            {

                if (mapa.Key.Equals(valor)) {
                    return mapa.Value;
                }
            }
            return valor;
            

        }
        public string codigo_produto(String valor)
        {

            Dictionary<string, string> codigoProduto = new Dictionary<string, string>(){

                {"001", "Visa Credito" },
                {"002", "Visa Debito" },
                {"003", "Master Credito" },
                {"004", "Master Debito" },
                {"022", "Elo Credito" },
                {"023", "Elo Debito" },
                {"024", "Amex Credito" },
                {"028", "Hipercard Credito" },
                {"033", "Cabal Credito" },
                {"034", "Cabal Débito" },
                {"092", "Boleto" },
                {"093", "PIX" },
                {"099", "QRCode" },

            };

            foreach (KeyValuePair<string, string> mapa in codigoProduto)
            {
                if (mapa.Key.Equals(valor))
                {
                    return mapa.Value;
                }
            }
            return valor;


        }

    }
}
