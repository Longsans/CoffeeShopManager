    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Products : DBConnection
    {
        public DAL_Products(string connString) : base(connString)
        {

        }

        /// <summary>
        /// Gets Id, Name, Type, Price and Image regarding all products;
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllProductsWithImages(int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price, Image FROM [PRODUCTS] " +
                "WHERE ShopId = @shopId AND Deleted = 0";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            ada.Fill(dt);
            if (!connState)
            {
                CloseConnection();
            }

            return dt;
        }

        public DataTable GetAllProductsWithoutImages(int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price FROM [PRODUCTS] " +
                "WHERE ShopId = @shopId AND Deleted = 0";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            ada.Fill(dt);
            if (!connState)
            {
                CloseConnection();
            }

            return dt;
        }

        public DTO_Product GetByIdNotDeleted(int id, int shopId)
        {
            DTO_Product dtoPro = null;
            string qry = "SELECT * " +
                "FROM [PRODUCTS] " +
                "WHERE Id = @id AND ShopId = @shopId AND Deleted = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoPro = new DTO_Product
                {
                    Id = id,
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = decimal.Round((decimal)reader["Price"], 2, MidpointRounding.AwayFromZero),
                    Details = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[],
                    Deleted = (bool)reader["Deleted"]
                };
                dtoPro.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DTO_Product GetByIdDeletedAndNotDeleted(int id, int shopId)
        {
            DTO_Product dtoPro = null;
            string qry = "SELECT * " +
                "FROM [PRODUCTS] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoPro = new DTO_Product
                {
                    Id = id,
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = decimal.Round((decimal)reader["Price"], 2, MidpointRounding.AwayFromZero),
                    Details = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[],
                    Deleted = (bool)reader["Deleted"]
                };
                dtoPro.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DTO_Product GetByNameNotDeleted(string name, int shopId)
        {
            DTO_Product dtoPro = null;
            string qry = "SELECT * " +
                "FROM [PRODUCTS] " +
                "WHERE Name = @name AND ShopId = @shopId AND Deleted = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoPro = new DTO_Product
                {
                    Id = (int)reader["Id"],
                    Name = name,
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = decimal.Round((decimal)reader["Price"], 2, MidpointRounding.AwayFromZero),
                    Details = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[],
                    Deleted = (bool)reader["Deleted"]
                };
                dtoPro.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DTO_Product GetByNameDeletedAndNotDeleted(string name, int shopId)
        {
            DTO_Product dtoPro = null;
            string qry = "SELECT * " +
                "FROM [PRODUCTS] " +
                "WHERE Name = @name AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                dtoPro = new DTO_Product
                {
                    Id = (int)reader["Id"],
                    Name = name,
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = decimal.Round((decimal)reader["Price"], 2, MidpointRounding.AwayFromZero),
                    Details = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[],
                    Deleted = (bool)reader["Deleted"]
                };
                dtoPro.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public bool CheckReceiptDetailsExist(DTO_Product dtoPro)
        {
            bool result = false;
            string qry = "SELECT * " +
                "FROM RECEIPT_DETAILS " +
                "WHERE ProductId = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                result = true;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return result;
        }

        public DataTable GetAllProductsOfType(string type, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price " +
                "FROM [PRODUCTS] " +
                "WHERE Type = @type AND ShopId = @shopId AND Deleted = 0";
            SqlDataAdapter ada = new SqlDataAdapter(qry, this.conn);
            ada.SelectCommand.Parameters.AddWithValue("@type", type);
            ada.SelectCommand.Parameters.AddWithValue("@shopId", shopId);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            ada.Fill(dt);
            if (!connState)
            {
                CloseConnection();
            }

            return dt;
        }

        public DataTable GetAllDrinks(int shopId)
        {
            return GetAllProductsOfType("Drink", shopId);
        }

        public DataTable GetAllFood(int shopId)
        {
            return GetAllProductsOfType("Food", shopId);
        }

        public DataTable GetAllOtherProducts(int shopId)
        {
            return GetAllProductsOfType("Others", shopId);
        }

        public DataTable GetProductsSearchIDFiltered(int id, int shopId)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price " +
                "FROM [PRODUCTS] " +
                "WHERE Id = @id AND ShopId = @shopId AND Deleted = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetProductsSearchNameFiltered(string nameSubstr, int shopId)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price " +
                "FROM [PRODUCTS] " +
                "WHERE Name LIKE '%' + @namesubstr + '%' " +
                "AND ShopId = @shopId AND Deleted = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@namesubstr", nameSubstr);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetProductsSearchTypeFiltered(string type, int shopId)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price " +
                "FROM [PRODUCTS] " +
                "WHERE Type = @type AND ShopId = @shopId AND Deleted = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetProductsSearchPriceFiltered(decimal lowerBound, decimal upperBound, int shopId)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, cast(Price as decimal(10, 2)) AS Price FROM [PRODUCTS] " +
                "WHERE (Price BETWEEN @lower AND @upper) AND ShopId = @shopId AND Deleted = 0";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@lower", lowerBound);
            cmd.Parameters.AddWithValue("@upper", upperBound);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetDataTableItemsOfProduct(int productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts(this.connectionString);
            return dalItemForPro.GetDataTableItemsOfProduct(productId, shopId);
        }

        public DTO_StockItemForProduct GetItemForProduct(int itemId, int productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts(this.connectionString);
            return dalItemForPro.GetItemForProduct(itemId, productId, shopId);
        }

        public void InsertWithoutImage(DTO_Product dtoPro)
        {
            string qry = "INSERT INTO [PRODUCTS] " +
                "(Name, Type, cast(Price as decimal(10, 2)) AS Price, Details, Deleted) " +
                "VALUES (@name, @type, @price, @details, @shopId, @del)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Details);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);
            cmd.Parameters.AddWithValue("@del", 0);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void InsertWithImage(DTO_Product dtoPro)
        {
            string qry = "INSERT INTO [PRODUCTS] (Name, Type, Image, Price, Details, ShopId, Deleted)" +
                "VALUES (@name, @type, @image, @price, @details, @shopId, @del)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@image", dtoPro.Image);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Details);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);
            cmd.Parameters.AddWithValue("@del", 0);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void FalseDelete(DTO_Product dtoPro)
        {
            string qry = "UPDATE [PRODUCTS] " +
                "SET Deleted = 1 " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            //
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void TrueDelete(DTO_Product dtoPro)
        {
            string qry = "DELETE FROM [PRODUCTS] " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            RemoveAllItemsForProductByProductId(dtoPro.Id, dtoPro.Shop.ID);
            RemoveAllReceiptsWithProductByProductId(dtoPro.Id, dtoPro.Shop.ID);
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void RestoreDeletedProduct(DTO_Product dtoPro)
        {
            string qry = "UPDATE [PRODUCTS] " +
                "SET Deleted = 0 " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void Update(DTO_Product dtoPro)
        {
            string qry = "UPDATE [PRODUCTS] SET " +
                "Name = @name, Type = @type, Image = @image, " +
                "Price = @price, Details = @details " +
                "WHERE Id = @id AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@image", dtoPro.Image);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Details);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@shopId", dtoPro.Shop.ID);

            var connState = (this.conn.State == ConnectionState.Open);
            if (!connState)
            {
                OpenConnection();
            }
            cmd.ExecuteNonQuery();
            if (!connState)
            {
                CloseConnection();
            }
        }

        public void AddItemForProduct(DTO_StockItemForProduct itemForPro)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts(this.connectionString);
            dalItemForPro.Insert(itemForPro);
        }

        public void RemoveItemForProduct(DTO_StockItemForProduct itemForPro)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts(this.connectionString);
            dalItemForPro.Delete(itemForPro);
        }

        public void RemoveAllItemsForProductByProductId(int productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts(this.connectionString);
            dalItemForPro.DeleteAllByProductId(productId, shopId);
        }

        public void RemoveAllReceiptsWithProductByProductId(int productId, int shopId)
        {
            DAL_Receipts dalRec = new DAL_Receipts(this.connectionString);
            var recList = dalRec.GetAllReceiptsByProductId(productId, shopId);
            foreach (var rec in recList)
            {
                dalRec.DeleteReceipt(rec);
            }
        }
    }
}
