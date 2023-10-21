namespace SQLServerProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new SQLServerProject.Database1DataSet();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new SQLServerProject.Database1DataSetTableAdapters.IngredientTableAdapter();
            this.tableAdapterManager = new SQLServerProject.Database1DataSetTableAdapters.TableAdapterManager();
            this.recipeIngredientTableAdapter = new SQLServerProject.Database1DataSetTableAdapters.RecipeIngredientTableAdapter();
            this.recipeTableAdapter = new SQLServerProject.Database1DataSetTableAdapters.RecipeTableAdapter();
            this.ingredientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ingredientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesListBox = new System.Windows.Forms.ListBox();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.newRecipeTextBox = new System.Windows.Forms.TextBox();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.updateRecipeTextBox = new System.Windows.Forms.TextBox();
            this.updateRecipeButton = new System.Windows.Forms.Button();
            this.allIngredientsListBox = new System.Windows.Forms.ListBox();
            this.allIngredientsLabel = new System.Windows.Forms.Label();
            this.AddToRecipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingNavigator)).BeginInit();
            this.ingredientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.database1DataSet;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IngredientTableAdapter = this.ingredientTableAdapter;
            this.tableAdapterManager.RecipeIngredientTableAdapter = this.recipeIngredientTableAdapter;
            this.tableAdapterManager.RecipeTableAdapter = this.recipeTableAdapter;
            this.tableAdapterManager.UpdateOrder = SQLServerProject.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // recipeIngredientTableAdapter
            // 
            this.recipeIngredientTableAdapter.ClearBeforeFill = true;
            // 
            // recipeTableAdapter
            // 
            this.recipeTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientBindingNavigator
            // 
            this.ingredientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingredientBindingNavigator.BindingSource = this.ingredientBindingSource;
            this.ingredientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingredientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingredientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ingredientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ingredientBindingNavigatorSaveItem});
            this.ingredientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingredientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingredientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingredientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingredientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingredientBindingNavigator.Name = "ingredientBindingNavigator";
            this.ingredientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingredientBindingNavigator.Size = new System.Drawing.Size(1024, 27);
            this.ingredientBindingNavigator.TabIndex = 0;
            this.ingredientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ingredientBindingNavigatorSaveItem
            // 
            this.ingredientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingredientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingredientBindingNavigatorSaveItem.Image")));
            this.ingredientBindingNavigatorSaveItem.Name = "ingredientBindingNavigatorSaveItem";
            this.ingredientBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ingredientBindingNavigatorSaveItem.Text = "Save Data";
            this.ingredientBindingNavigatorSaveItem.Click += new System.EventHandler(this.IngredientBindingNavigatorSaveItem_Click);
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataMember = "Recipe";
            this.recipeBindingSource.DataSource = this.database1DataSet;
            // 
            // recipeIngredientBindingSource
            // 
            this.recipeIngredientBindingSource.DataMember = "RecipeIngredient";
            this.recipeIngredientBindingSource.DataSource = this.database1DataSet;
            // 
            // recipesListBox
            // 
            this.recipesListBox.FormattingEnabled = true;
            this.recipesListBox.ItemHeight = 16;
            this.recipesListBox.Location = new System.Drawing.Point(61, 92);
            this.recipesListBox.Name = "recipesListBox";
            this.recipesListBox.Size = new System.Drawing.Size(157, 164);
            this.recipesListBox.TabIndex = 4;
            this.recipesListBox.SelectedIndexChanged += new System.EventHandler(this.RecipesListBox_SelectedIndexChanged);
            // 
            // recipesLabel
            // 
            this.recipesLabel.AutoSize = true;
            this.recipesLabel.Location = new System.Drawing.Point(103, 73);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(58, 16);
            this.recipesLabel.TabIndex = 5;
            this.recipesLabel.Text = "Recipes";
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(292, 73);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(73, 16);
            this.ingredientsLabel.TabIndex = 6;
            this.ingredientsLabel.Text = "Ingredients";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 16;
            this.ingredientsListBox.Location = new System.Drawing.Point(260, 92);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(157, 164);
            this.ingredientsListBox.TabIndex = 7;
            // 
            // newRecipeTextBox
            // 
            this.newRecipeTextBox.Location = new System.Drawing.Point(492, 73);
            this.newRecipeTextBox.Name = "newRecipeTextBox";
            this.newRecipeTextBox.Size = new System.Drawing.Size(100, 22);
            this.newRecipeTextBox.TabIndex = 8;
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(476, 101);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(138, 35);
            this.addRecipeButton.TabIndex = 9;
            this.addRecipeButton.Text = "Add New Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // updateRecipeTextBox
            // 
            this.updateRecipeTextBox.Location = new System.Drawing.Point(492, 187);
            this.updateRecipeTextBox.Name = "updateRecipeTextBox";
            this.updateRecipeTextBox.Size = new System.Drawing.Size(100, 22);
            this.updateRecipeTextBox.TabIndex = 10;
            // 
            // updateRecipeButton
            // 
            this.updateRecipeButton.Location = new System.Drawing.Point(476, 215);
            this.updateRecipeButton.Name = "updateRecipeButton";
            this.updateRecipeButton.Size = new System.Drawing.Size(138, 31);
            this.updateRecipeButton.TabIndex = 11;
            this.updateRecipeButton.Text = "Update Recipe";
            this.updateRecipeButton.UseVisualStyleBackColor = true;
            this.updateRecipeButton.Click += new System.EventHandler(this.UpdateRecipeButton_Click);
            // 
            // allIngredientsListBox
            // 
            this.allIngredientsListBox.FormattingEnabled = true;
            this.allIngredientsListBox.ItemHeight = 16;
            this.allIngredientsListBox.Location = new System.Drawing.Point(643, 92);
            this.allIngredientsListBox.Name = "allIngredientsListBox";
            this.allIngredientsListBox.Size = new System.Drawing.Size(157, 164);
            this.allIngredientsListBox.TabIndex = 12;
            // 
            // allIngredientsLabel
            // 
            this.allIngredientsLabel.AutoSize = true;
            this.allIngredientsLabel.Location = new System.Drawing.Point(671, 73);
            this.allIngredientsLabel.Name = "allIngredientsLabel";
            this.allIngredientsLabel.Size = new System.Drawing.Size(91, 16);
            this.allIngredientsLabel.TabIndex = 13;
            this.allIngredientsLabel.Text = "All Ingredients";
            // 
            // AddToRecipeButton
            // 
            this.AddToRecipeButton.Location = new System.Drawing.Point(831, 174);
            this.AddToRecipeButton.Name = "AddToRecipeButton";
            this.AddToRecipeButton.Size = new System.Drawing.Size(128, 35);
            this.AddToRecipeButton.TabIndex = 14;
            this.AddToRecipeButton.Text = "Add To Recipe";
            this.AddToRecipeButton.UseVisualStyleBackColor = true;
            this.AddToRecipeButton.Click += new System.EventHandler(this.AddToRecipeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 340);
            this.Controls.Add(this.AddToRecipeButton);
            this.Controls.Add(this.allIngredientsLabel);
            this.Controls.Add(this.allIngredientsListBox);
            this.Controls.Add(this.updateRecipeButton);
            this.Controls.Add(this.updateRecipeTextBox);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.newRecipeTextBox);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.recipesLabel);
            this.Controls.Add(this.recipesListBox);
            this.Controls.Add(this.ingredientBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingNavigator)).EndInit();
            this.ingredientBindingNavigator.ResumeLayout(false);
            this.ingredientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private Database1DataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingredientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ingredientBindingNavigatorSaveItem;
        private Database1DataSetTableAdapters.RecipeTableAdapter recipeTableAdapter;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private Database1DataSetTableAdapters.RecipeIngredientTableAdapter recipeIngredientTableAdapter;
        private System.Windows.Forms.BindingSource recipeIngredientBindingSource;
        private System.Windows.Forms.ListBox recipesListBox;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.TextBox newRecipeTextBox;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.TextBox updateRecipeTextBox;
        private System.Windows.Forms.Button updateRecipeButton;
        private System.Windows.Forms.ListBox allIngredientsListBox;
        private System.Windows.Forms.Label allIngredientsLabel;
        private System.Windows.Forms.Button AddToRecipeButton;
    }
}

