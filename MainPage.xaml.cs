using PickRandomCards;

namespace PickRandomCardsMAUI;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void PickCardsButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(NumberOfCards.Text, out int numCards))
        {
            PickedCards.Text = String.Empty;
            string[] pickedCards = CardPicker.PickSomeCards(numCards);
            foreach (string card in pickedCards)
            {
                PickedCards.Text += card + Environment.NewLine;
            }

            PickedCards.Text += Environment.NewLine + "You picked " + numCards + " cards.";

        }
        else
        {
            PickedCards.Text = "Please enter a valid number";
        }


    }
}
