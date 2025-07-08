namespace ECommerceSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string productsText = "�r�nler";
            var addToCartButtonText = "Sepete Ekle";
            var CartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepetten �ikar";

            btnAddToCart.Text = addToCartButtonText;
            lblProducts.Text = productsText;
            lblCart.Text = CartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[] { "Laptop", "Masa�st� PC", "Klavye" };


            //for (int i = 0; i < products.Length; i++)
            //{

            //    lbxProducts.Items.Add(products[i]);
            //}


            foreach (var item in products)
            {

                lbxProducts.Items.Add(item);
            }


            if (lbxCart.Items.Count == 0)
            {

                btnRemoveFromCart.Enabled = false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }

            else
            {


                MessageBox.Show("�ncelike bir �r�n se�melisiniz");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);

            }

            else
            {
                MessageBox.Show("�ncelikle bir �r�n se�iniz");

            }
            if (lbxCart.Items.Count == 0)
            {

                btnRemoveFromCart.Enabled = false;

            }



        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
