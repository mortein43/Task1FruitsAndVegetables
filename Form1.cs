// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Task1FruitsAndVegetables;
using System.Data;
using Microsoft.Data.Sqlite;

public partial class Form1 : Form
{
    private string connectionString = "Data Source= FruitsAndVegetables.sqlite;";

    /// <summary>
    /// Initializes a new  instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        this.InitializeComponent();
        this.colorInput.SelectedIndex = 0;
        this.caloriesInput.SelectedIndex = 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _ = this.CreateDataBase();
        _ = this.CreateTable();
        _ = this.LoadData();
    }

    private async Task CreateDataBase()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ()
        {
            CommandText = "CREATE DATABASE FruitsAndVegetables",
            Connection = connection,
        };

        await command.ExecuteNonQueryAsync();
    }

    private async Task CreateTable()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand checkTableCommand = new ()
        {
            CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='AllFruitsAndVegetables';",
            Connection = connection,
        };

        var result = await checkTableCommand.ExecuteScalarAsync();

        if (result == null)
        {
            SqliteCommand createTableCommand = new ()
            {
                CommandText = "CREATE TABLE AllFruitsAndVegetables (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name NVARCHAR(255), Type NVARCHAR(255), Color NVARCHAR(255), Caloric INT)",
                Connection = connection,
            };

            await createTableCommand.ExecuteNonQueryAsync();

            await this.TableFilling();
        }
    }

    private async Task TableFilling()
    {
        string sqliteExpression = "INSERT OR IGNORE INTO AllFruitsAndVegetables (Name, Type, Color, Caloric)  VALUES " +
            "('Pineapple', 'Fruit', 'Yellow', 54), " +
            "('Apple', 'Fruit', 'Red', 46), " +
            "('Pear', 'Fruit', 'Yellow', 54), " +
            "('Lemon', 'Fruit', 'Yellow', 36), " +
            "('Strawberry', 'Fruit', 'Red', 33), " +
            "('Potato', 'Vegetable', 'Brown', 80), " +
            "('Cucumber', 'Vegetable', 'Green', 15), " +
            "('Tomato', 'Vegetable', 'Red', 19), " +
            "('Horseradish', 'Vegetable', 'White', 67), " +
            "('Corn', 'Vegetable', 'Yellow', 97)";

        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();
        SqliteCommand command = new (sqliteExpression, connection);
        await command.ExecuteNonQueryAsync();
    }

    private async Task LoadData()
    {
        this.dataGridView1.DataSource = string.Empty;
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllNamesFruitsAndVegetables()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT Name FROM AllFruitsAndVegetables", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllColors()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT Color FROM AllFruitsAndVegetables GROUP BY Color", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadMaxCaloric()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT Name, Type, Color, MAX(Caloric) AS Caloric FROM AllFruitsAndVegetables", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadMinCaloric()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT Name, Type, Color, MIN(Caloric) AS Caloric FROM AllFruitsAndVegetables", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAverageCaloric()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT COALESCE('Average Caloric', 'Average Caloric') AS Name,  AVG(Caloric) AS Caloric FROM AllFruitsAndVegetables", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAmountOfVegetables()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT COALESCE('Vegetables', null) AS Type,  Count(Type) AS Number FROM AllFruitsAndVegetables WHERE Type = 'Vegetable'", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAmountOfFruits()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ("SELECT COALESCE('Fruits', null) AS Type,  Count(Type) AS Number FROM AllFruitsAndVegetables WHERE Type = 'Fruit'", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllForColor()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ($"SELECT COALESCE('Fruits and Vegetables', null) AS Type,  Count(Color) AS Number FROM AllFruitsAndVegetables WHERE Color = '{this.colorInput.Text}'", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAmountForColors()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ($"SELECT Color,  Count(Color) AS Number FROM AllFruitsAndVegetables GROUP BY Color", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllForLess()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ($"SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Caloric < {int.Parse(this.caloriesInput.Text)}", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllForMore()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ($"SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Caloric > {int.Parse(this.caloriesInput.Text)}", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllForGivenColor()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ($"SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Color = '{this.colorInput.Text}'", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private async Task LoadAllForCalorieRange()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand command = new ($"SELECT Id, Name, Type, Color, Caloric FROM AllFruitsAndVegetables WHERE Caloric > {this.numericUpDown1.Value} AND Caloric < {this.numericUpDown2.Value} OR Caloric < {this.numericUpDown1.Value} AND Caloric > {this.numericUpDown2.Value}", connection);

        using SqliteDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new ();
        dataTable.Load(reader);

        this.dataGridView1.DataSource = dataTable;
    }

    private void RadioAll_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadData();
    }

    private void AllNames_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadAllNamesFruitsAndVegetables();
    }

    private void AllColors_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadAllColors();
    }

    private void MaxCaloric_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadMaxCaloric();
    }

    private void MinCaloric_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadMinCaloric();
    }

    private void AverageCalorie_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadAverageCaloric();
    }

    private void AmountOfVegetables_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadAmountOfVegetables();
    }

    private void AmountOfFruits_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadAmountOfFruits();
    }

    private void AllForColor_CheckedChanged(object sender, EventArgs e)
    {
        if (this.allForColor.Checked)
        {
            _ = this.LoadAllForColor();
        }
    }

    private void AmountForColors_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.LoadAmountForColors();
    }

    private void Less_CheckedChanged(object sender, EventArgs e)
    {
        if (this.less.Checked)
        {
            _ = this.LoadAllForLess();
        }
    }

    private void More_CheckedChanged(object sender, EventArgs e)
    {
        if (this.more.Checked)
        {
            _ = this.LoadAllForMore();
        }
    }

    private void AllOfGivenColor_CheckedChanged(object sender, EventArgs e)
    {
        if (this.allOfGivenColor.Checked)
        {
            _ = this.LoadAllForGivenColor();
        }
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (this.calorieRange.Checked)
        {
            _ = this.LoadAllForCalorieRange();
        }
    }
}
