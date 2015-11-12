using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Test_autoescuela
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        void OnOkButtonClick(object sender, RoutedEventArgs args)
        {
            int sol = 0;
            if (unoA.IsChecked == true) { sol++; soluno.Text = "Respuesta correcta"; soluno.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soluno.Text = "Respuesta incorrecta. La respuesta correcta era la A"; soluno.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (dosB.IsChecked == true) { sol++; soldos.Text = "Respuesta correcta"; soldos.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldos.Text = "Respuesta incorrecta. La respuesta correcta era la B"; soldos.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (tresC.IsChecked == true) { sol++; soltres.Text = "Respuesta correcta"; soltres.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soltres.Text = "Respuesta incorrecta. La respuesta correcta era la C"; soltres.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (cuatroC.IsChecked == true) { sol++; solcuatro.Text = "Respuesta correcta"; solcuatro.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solcuatro.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solcuatro.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (cincoC.IsChecked == true) { sol++; solcinco.Text = "Respuesta correcta"; solcinco.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solcinco.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solcinco.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (seisA.IsChecked == true) { sol++; solseis.Text = "Respuesta correcta"; solseis.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solseis.Text = "Respuesta incorrecta. La respuesta correcta era la A"; solseis.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (sieteC.IsChecked == true) { sol++; solsiete.Text = "Respuesta correcta"; solsiete.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solsiete.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solsiete.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (ochoA.IsChecked == true) { sol++; solocho.Text = "Respuesta correcta"; solocho.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solocho.Text = "Respuesta incorrecta. La respuesta correcta era la A"; solocho.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (nueveC.IsChecked == true) { sol++; solnueve.Text = "Respuesta correcta"; solnueve.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solnueve.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solnueve.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (diezA.IsChecked == true) { sol++; soldiez.Text = "Respuesta correcta"; soldiez.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldiez.Text = "Respuesta incorrecta. La respuesta correcta era la A"; soldiez.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (onceC.IsChecked == true) { sol++; solonce.Text = "Respuesta correcta"; solonce.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solonce.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solonce.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (doceC.IsChecked == true) { sol++; soldoce.Text = "Respuesta correcta"; soldoce.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldoce.Text = "Respuesta incorrecta. La respuesta correcta era la C"; soldoce.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (treceB.IsChecked == true) { sol++; soltrece.Text = "Respuesta correcta"; soltrece.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soltrece.Text = "Respuesta incorrecta. La respuesta correcta era la B"; soltrece.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (catorceB.IsChecked == true) { sol++; solcatorce.Text = "Respuesta correcta"; solcatorce.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solcatorce.Text = "Respuesta incorrecta. La respuesta correcta era la B"; solcatorce.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (quinceC.IsChecked == true) { sol++; solquince.Text = "Respuesta correcta"; solquince.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solquince.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solquince.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (dieciseisC.IsChecked == true) { sol++; soldieciseis.Text = "Respuesta correcta"; soldieciseis.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldieciseis.Text = "Respuesta incorrecta. La respuesta correcta era la C"; soldieciseis.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (diecisieteA.IsChecked == true) { sol++; soldiecisiete.Text = "Respuesta correcta"; soldiecisiete.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldiecisiete.Text = "Respuesta incorrecta. La respuesta correcta era la A"; soldiecisiete.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (dieciochoB.IsChecked == true) { sol++; soldieciocho.Text = "Respuesta correcta"; soldieciocho.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldieciocho.Text = "Respuesta incorrecta. La respuesta correcta era la B"; soldieciocho.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (diecinueveC.IsChecked == true) { sol++; soldiecinueve.Text = "Respuesta correcta"; soldiecinueve.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soldiecinueve.Text = "Respuesta incorrecta. La respuesta correcta era la C"; soldiecinueve.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veinteC.IsChecked == true) { sol++; solveinte.Text = "Respuesta correcta"; solveinte.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveinte.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solveinte.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veinteunoB.IsChecked == true) { sol++; solveinteuno.Text = "Respuesta correcta"; solveinteuno.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveinteuno.Text = "Respuesta incorrecta. La respuesta correcta era la B"; solveinteuno.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veintedosB.IsChecked == true) { sol++; solveintedos.Text = "Respuesta correcta"; solveintedos.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveintedos.Text = "Respuesta incorrecta. La respuesta correcta era la B"; solveintedos.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veintetresC.IsChecked == true) { sol++; solveintetres.Text = "Respuesta correcta"; solveintetres.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveintetres.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solveintetres.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veintecuatroA.IsChecked == true) { sol++; solveintecuatro.Text = "Respuesta correcta"; solveintecuatro.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveintecuatro.Text = "Respuesta incorrecta. La respuesta correcta era la A"; solveintecuatro.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veintecincoC.IsChecked == true) { sol++; solveintecinco.Text = "Respuesta correcta"; solveintecinco.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveintecinco.Text = "Respuesta incorrecta. La respuesta correcta era la C"; solveintecinco.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veinteseisA.IsChecked == true) { sol++; solveinteseis.Text = "Respuesta correcta"; solveinteseis.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveinteseis.Text = "Respuesta incorrecta. La respuesta correcta era la A"; solveinteseis.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veintesieteB.IsChecked == true) { sol++; solveintesiete.Text = "Respuesta correcta"; solveintesiete.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveintesiete.Text = "Respuesta incorrecta. La respuesta correcta era la B"; solveintesiete.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veinteochoB.IsChecked == true) { sol++; solveinteocho.Text = "Respuesta correcta"; solveinteocho.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveinteocho.Text = "Respuesta incorrecta. La respuesta correcta era la B"; solveinteocho.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (veintenueveB.IsChecked == true) { sol++; solveintenueve.Text = "Respuesta correcta"; solveintenueve.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { solveintenueve.Text = "Respuesta incorrecta. La respuesta correcta era la B"; solveintenueve.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (trentaB.IsChecked == true) { sol++; soltrenta.Text = "Respuesta correcta"; soltrenta.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0)); } else { soltrenta.Text = "Respuesta incorrecta. La respuesta correcta era la B"; soltrenta.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0)); }
            if (sol==1)
                resposta.Text = "Has acertado " + sol.ToString() + " pregunta. ";
            else
                resposta.Text = "Has acertado " + sol.ToString() + " preguntas. ";
            if (sol > 26)
            {
                resposta.Text += "APROBADO";
                resposta.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            else
            {
                resposta.Text += "SUSPENDIDO";
                resposta.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
            /*foreach (UIElement child in radioButtonPanel.Children)
            {

                RadioButton radio = child as RadioButton;
                if ((bool)radio.IsChecked)
                    (Application.Current as App).ElapsedTimeFormat =
                   (ElapsedTimeFormat)Enum.Parse(typeof(ElapsedTimeFormat),
                       radio.Tag as string, true);
            }*/
        }
    }
}

