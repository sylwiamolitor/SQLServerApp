using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SQLServerProject
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
                "SQLServerProject.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void IngredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateAllIngredients();

        }
        private void PopulateRecipes()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", sqlConnection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                recipesListBox.DisplayMember = "Name";
                recipesListBox.ValueMember = "Id";
                recipesListBox.DataSource = table;


            }


        }
        private void PopulateIngredients()
        {
            string query = "SELECT a.Name FROM Ingredient a INNER JOIN RecipeIngredient b " +
                "ON a.Id = b.IngredientId WHERE b.RecipeId = @RecipeId";
            using (sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", recipesListBox.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                ingredientsListBox.DisplayMember = "Name";
                ingredientsListBox.ValueMember = "Id";
                ingredientsListBox.DataSource = ingredientTable;


            }


        }
        private void PopulateAllIngredients()
        {
            string query = "SELECT * FROM Ingredient";
            using (sqlConnection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                allIngredientsListBox.DisplayMember = "Name";
                allIngredientsListBox.ValueMember = "Id";
                allIngredientsListBox.DataSource = ingredientTable;


            }


        }

        private void RecipesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Chosen recipe: " + recipesListBox.SelectedValue.ToString());
            PopulateIngredients();
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName, 80, 'complete later')";
            using (sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();

                command.Parameters.AddWithValue("@RecipeName", newRecipeTextBox.Text);

                command.ExecuteScalar();

                PopulateRecipes();


            }
        }

        private void UpdateRecipeButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeId";
            using (sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();

                command.Parameters.AddWithValue("@RecipeName", updateRecipeTextBox.Text);
                command.Parameters.AddWithValue("@RecipeId", recipesListBox.SelectedIndex);

                command.ExecuteScalar();

                PopulateRecipes();

            }
        }
        //without exception handling
        private void AddToRecipeButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient VALUES (@RecipeId, @IngredientId)";
            using (sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                sqlConnection.Open();

                command.Parameters.AddWithValue("@RecipeId", recipesListBox.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", allIngredientsListBox.SelectedValue);

                command.ExecuteScalar();

                PopulateIngredients();
            }

        }
    }
}
