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
        /// <summary>
        /// Gets Id, Name, Type, Price and Image regarding all products;
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllProductsWithImages(int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, Price, Image FROM [PRODUCTS] " +
                "WHERE ShopId = @shopId";
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
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] " +
                "WHERE ShopId = @shopId";
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

        public DTO_Product GetById(string id, int shopId)
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
                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                    Detail = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[],
                };
                dtoPro.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DTO_Product GetByName(string name, int shopId)
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
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Name = name,
                    Type = reader.GetString(reader.GetOrdinal("Type")),
                    Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                    Detail = reader.GetString(reader.GetOrdinal("Details")),
                    Image = reader.GetValue(reader.GetOrdinal("Image")) as byte[],
                };
                dtoPro.Shop.ID = shopId;
            }
            if (!connState)
            {
                CloseConnection();
            }

            return dtoPro;
        }

        public DataTable GetAllProductsOfType(string type, int shopId)
        {
            DataTable dt = new DataTable();
            string qry = "SELECT Id, Name, Type, Price " +
                "FROM [PRODUCTS] " +
                "WHERE Type = @type AND ShopId = @shopId";
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

        public DataTable GetProductsSearchIDFiltered(string id, int shopId)
        {
            DataTable dtProFiltered = new DataTable();
            string qry = "SELECT Id, Name, Type, Price " +
                "FROM [PRODUCTS] " +
                "WHERE Id = @id AND ShopId = @shopId";
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
            string qry = "SELECT Id, Name, Type, Price " +
                "FROM [PRODUCTS] " +
                "WHERE Name LIKE '%' + @namesubstr + '%' " +
                "AND ShopId = @shopId";
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
            string qry = "SELECT Id, Name, Type, Price " +
                "FROM [PRODUCTS] " +
                "WHERE Type = @type AND ShopId = @shopId";
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
            string qry = "SELECT Id, Name, Type, Price FROM [PRODUCTS] " +
                "WHERE (Price BETWEEN @lower AND @upper) AND ShopId = @shopId";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@lower", lowerBound);
            cmd.Parameters.AddWithValue("@upper", upperBound);
            cmd.Parameters.AddWithValue("@shopId", shopId);
            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            ada.Fill(dtProFiltered);

            return dtProFiltered;
        }

        public DataTable GetDataTableItemsOfProduct(string productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            return dalItemForPro.GetDataTableItemsOfProduct(productId, shopId);
        }

        public DTO_StockItemsForProducts GetItemForProduct(string itemId, string productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            return dalItemForPro.GetItemForProduct(itemId, productId, shopId);
        }

        public void InsertWithoutImage(DTO_Product dtoPro)
        {
            string qry = "INSERT INTO [PRODUCTS] " +
                "(Id, Name, Type, Price, Details) " +
                "VALUES (@id, @name, @type, @price, @details, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Detail);
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

        public void InsertWithImage(DTO_Product dtoPro)
        {
            string qry = "INSERT INTO [PRODUCTS] " +
                "VALUES (@id, @name, @type, @image, @price, @details, @shopId)";
            SqlCommand cmd = new SqlCommand(qry, this.conn);
            cmd.Parameters.AddWithValue("@id", dtoPro.Id);
            cmd.Parameters.AddWithValue("@name", dtoPro.Name);
            cmd.Parameters.AddWithValue("@type", dtoPro.Type);
            cmd.Parameters.AddWithValue("@image", dtoPro.Image);
            cmd.Parameters.AddWithValue("@price", dtoPro.Price);
            cmd.Parameters.AddWithValue("@details", dtoPro.Detail);
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

        public void Delete(DTO_Product dtoPro)
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
            cmd.Parameters.AddWithValue("@details", dtoPro.Detail);
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

        public void AddItemForProduct(DTO_StockItemsForProducts itemForPro)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            dalItemForPro.Insert(itemForPro);
        }

        public void RemoveItemForProduct(DTO_StockItemsForProducts itemForPro)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            dalItemForPro.Delete(itemForPro);
        }

        public void RemoveAllItemsForProductByProductId(string productId, int shopId)
        {
            DAL_StockItemsForProducts dalItemForPro = new DAL_StockItemsForProducts();
            dalItemForPro.DeleteAllByProductId(productId, shopId);
        }
    }
}
