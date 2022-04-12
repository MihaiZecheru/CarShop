using CarClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        // binding sources are objects that associate a class to a control (class i.e. store)
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();

        public string trim(string x)
        {
            char[] chars = { ' ', '.', '!' };
            return x.Trim(chars);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_createCar_Click(object sender, EventArgs e)
        {
            if (trim(txt_make.Text) == "" || trim(txt_model.Text) == "" || trim(txt_price.Text) == "")
            {
                MessageBox.Show("Field cannot be left blank");
                return;
            }

            decimal price;
            bool isNum = decimal.TryParse(txt_price.Text, out price);

            if (!isNum) // price field was not numeric
            {
                MessageBox.Show("Car price must be a number.");
                // clear price text field
                txt_price.Text = "";
                return;
            }

            // txt_make is the form element, .Text gets the content
            // like in js with ele.text or ele.innerHtml
            Car car = new Car(txt_make.Text, txt_model.Text, price);
            store.carList.Add(car); // add car to store

            // reset bindings when the values in a list have changed (update listbox)
            carInventoryBindingSource.ResetBindings(false);
            
            // reset textboxes on submission
            txt_make.Text = "";
            txt_model.Text = "";
            txt_price.Text = "";

        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            // get the selected item from inventory
            var selectedItems = lst_inv.SelectedItems;
            foreach(var item in selectedItems)
            {
                // this is called "type casting"
                // put a datatype in parenthesis in front of a var and it will convert it
                // for example (int)myString will convert myString to int
                Car selectedCar = (Car)item;
                store.shoppingList.Add(selectedCar);
            }

            // update the listbox
            cartBindingSource.ResetBindings(false);

            // add the selected item to the cart
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = store.Checkout();
            lbl_total.Text = "$" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* this function is "on form load" */

            // set car inv bindingSource to store.carList
            carInventoryBindingSource.DataSource = store.carList;

            // bind carInventoryBindingSource to inventoryList on form
            lst_inv.DataSource = carInventoryBindingSource;

            // add a member to the listbox ele
            lst_inv.DisplayMember = ToString();

            // -------------------------------------------------------

            cartBindingSource.DataSource = store.shoppingList;
            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }
    }
}