using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCifra : Form
    {
        public frmCifra()
        {
            InitializeComponent();


        }

        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            // converte o passo para inteiro
            int passo = Convert.ToInt32(numeric_passo.Value);
            lbl_passo.Text = passo.ToString();
            //limpar a textbox do resultado
            txt_resultado.Text = string.Empty;

            //Ciclo para converter toda a mensagem
            for (int i = 0; i < txt_mensagem.Text.Length; i++)
            {

                //Devolve o código ASCII da letra
                int ASCII = Convert.ToInt32(txt_mensagem.Text[i]);

                //verificacao para eliminar espaços e caracteres que nao sejam letras e numeros
                //  if (ASCII >= 0 && ASCII <= 9 || ASCII >= 'A' && ASCII <= 'Z' || ASCII >= 'a' && ASCII <= 'z')
                //  if (ASCII + passo > 'Z' ||)
                if (ASCII >= '0' && ASCII <= '9') // numero

                {
                    int passo_numero = passo;
                    if (passo >= 10)
                    {
                        passo_numero = passo % 10;
                        lbl_passo.Text = passo_numero.ToString();
                    }

                    if (ASCII + passo_numero >= 9)
                    {

                        int ASCII_CONVERTIDO = (ASCII) + passo_numero;
                        txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                    }
                    //else
                    //{
                    //    int ASCII_CONVERTIDO = ASCII + passo;
                    //    txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                    //}

                }

                else if (ASCII >= 'A' && ASCII <= 'Z') // maiuscula
                {
                    int passo_letra = passo;
                    if (passo >= 25)
                    {
                        passo_letra = passo % 10;
                        lbl_passo.Text = passo_letra.ToString();
                    }

                    if (ASCII + passo_letra >= 25)
                    {

                        int ASCII_CONVERTIDO = (ASCII) + passo_letra;
                        txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                    }
                }
                else if (ASCII >= 'a' && ASCII <= 'z') // minuscula

                {

                    int passo_letra = passo;
                    if (passo >= 25)
                    {
                        passo_letra = passo % 10;
                        lbl_passo.Text = passo_letra.ToString();
                    }

                    if (ASCII + passo_letra >= 25)
                    {

                        int ASCII_CONVERTIDO = (ASCII) + passo_letra;
                        txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);

                    }

                }
                else
                {
                    txt_resultado.Text += Char.ConvertFromUtf32(ASCII);
                }
            }
        }
        private void btn_desencriptar_Click(object sender, EventArgs e)
        {
            // converte o passo para inteiro
            int passo = Convert.ToInt32(numeric_passo.Value);
            lbl_passo.Text = passo.ToString();
            //limpar a textbox do resultado
            txt_resultado.Text = string.Empty;

            //Ciclo para converter toda a mensagem
            for (int i = 0; i < txt_mensagem.Text.Length; i++)
            {

                //Devolve o código ASCII da letra
                int ASCII = Convert.ToInt32(txt_mensagem.Text[i]);

                //verificacao para eliminar espaços e caracteres que nao sejam letras e numeros
                //  if (ASCII >= 0 && ASCII <= 9 || ASCII >= 'A' && ASCII <= 'Z' || ASCII >= 'a' && ASCII <= 'z')
                //  if (ASCII + passo > 'Z' ||)
                if (ASCII >= '0' && ASCII <= '9') // numero

                {
                    int passo_numero = passo;
                    if (passo >= 10)
                    {
                        passo_numero = passo % 10;
                        lbl_passo.Text = passo_numero.ToString();
                    }

                    if (ASCII - passo_numero >= 9)
                    {
                        if (ASCII - passo_numero <= 48)
                        {
                            int ASCII_CONVERTIDO = (ASCII) - passo_numero + 9;
                            txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                        }
                        else
                        {
                            int ASCII_CONVERTIDO = (ASCII) - passo_numero;
                            txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                        }
                       
                    }
                    //else
                    //{
                    //    int ASCII_CONVERTIDO = ASCII + passo;
                    //    txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                    //}

                }

                else if (ASCII >= 'A' && ASCII <= 'Z') // maiuscula
                {
                    int passo_letra = passo;
                    if (passo >= 25)
                    {
                        passo_letra = passo % 10;
                        lbl_passo.Text = passo_letra.ToString();
                    }

                    if (ASCII + passo_letra >= 65)
                    {

                        int ASCII_CONVERTIDO = (ASCII) - passo_letra + 24;
                        txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);
                    }
                }
                else if (ASCII >= 'a' && ASCII <= 'z') // minuscula

                {

                    int passo_letra = passo;
                    if (passo >= 25)
                    {
                        passo_letra = passo % 10;
                        lbl_passo.Text = passo_letra.ToString();
                    }

                    if (ASCII + passo_letra >= 65)
                    {

                        int ASCII_CONVERTIDO = (ASCII) - passo_letra + 24;
                        txt_resultado.Text += Char.ConvertFromUtf32(ASCII_CONVERTIDO);

                    }

                }
                else
                {
                    txt_resultado.Text += Char.ConvertFromUtf32(ASCII);
                }
            }
        }
    }
}
