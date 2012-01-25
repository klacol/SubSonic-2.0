using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace NorthwindAccess{
    /// <summary>
    /// Strongly-typed collection for the ProductSalesFor1997 class.
    /// </summary>
    [Serializable]
    public partial class ProductSalesFor1997Collection : ReadOnlyList<ProductSalesFor1997, ProductSalesFor1997Collection>
    {        
        public ProductSalesFor1997Collection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the Product Sales for 1997 view.
    /// </summary>
    [Serializable]
    public partial class ProductSalesFor1997 : ReadOnlyRecord<ProductSalesFor1997>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("Product Sales for 1997", TableType.View, DataService.GetInstance("NorthwindAccess"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"";
                //columns
                
                TableSchema.TableColumn colvarCategoryName = new TableSchema.TableColumn(schema);
                colvarCategoryName.ColumnName = "CategoryName";
                colvarCategoryName.DataType = DbType.String;
                colvarCategoryName.MaxLength = 15;
                colvarCategoryName.AutoIncrement = false;
                colvarCategoryName.IsNullable = true;
                colvarCategoryName.IsPrimaryKey = false;
                colvarCategoryName.IsForeignKey = false;
                colvarCategoryName.IsReadOnly = false;
                
                schema.Columns.Add(colvarCategoryName);
                
                TableSchema.TableColumn colvarProductName = new TableSchema.TableColumn(schema);
                colvarProductName.ColumnName = "ProductName";
                colvarProductName.DataType = DbType.String;
                colvarProductName.MaxLength = 40;
                colvarProductName.AutoIncrement = false;
                colvarProductName.IsNullable = true;
                colvarProductName.IsPrimaryKey = false;
                colvarProductName.IsForeignKey = false;
                colvarProductName.IsReadOnly = false;
                
                schema.Columns.Add(colvarProductName);
                
                TableSchema.TableColumn colvarProductSales = new TableSchema.TableColumn(schema);
                colvarProductSales.ColumnName = "ProductSales";
                colvarProductSales.DataType = DbType.Currency;
                colvarProductSales.MaxLength = 0;
                colvarProductSales.AutoIncrement = false;
                colvarProductSales.IsNullable = true;
                colvarProductSales.IsPrimaryKey = false;
                colvarProductSales.IsForeignKey = false;
                colvarProductSales.IsReadOnly = false;
                
                schema.Columns.Add(colvarProductSales);
                
                TableSchema.TableColumn colvarShippedQuarter = new TableSchema.TableColumn(schema);
                colvarShippedQuarter.ColumnName = "ShippedQuarter";
                colvarShippedQuarter.DataType = DbType.String;
                colvarShippedQuarter.MaxLength = 255;
                colvarShippedQuarter.AutoIncrement = false;
                colvarShippedQuarter.IsNullable = true;
                colvarShippedQuarter.IsPrimaryKey = false;
                colvarShippedQuarter.IsForeignKey = false;
                colvarShippedQuarter.IsReadOnly = false;
                
                schema.Columns.Add(colvarShippedQuarter);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["NorthwindAccess"].AddSchema("Product Sales for 1997",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public ProductSalesFor1997()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ProductSalesFor1997(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ProductSalesFor1997(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ProductSalesFor1997(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("CategoryName")]
        [Bindable(true)]
        public string CategoryName 
	    {
		    get
		    {
			    return GetColumnValue<string>("CategoryName");
		    }
            set 
		    {
			    SetColumnValue("CategoryName", value);
            }
        }
	      
        [XmlAttribute("ProductName")]
        [Bindable(true)]
        public string ProductName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ProductName");
		    }
            set 
		    {
			    SetColumnValue("ProductName", value);
            }
        }
	      
        [XmlAttribute("ProductSales")]
        [Bindable(true)]
        public decimal? ProductSales 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("ProductSales");
		    }
            set 
		    {
			    SetColumnValue("ProductSales", value);
            }
        }
	      
        [XmlAttribute("ShippedQuarter")]
        [Bindable(true)]
        public string ShippedQuarter 
	    {
		    get
		    {
			    return GetColumnValue<string>("ShippedQuarter");
		    }
            set 
		    {
			    SetColumnValue("ShippedQuarter", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string CategoryName = @"CategoryName";
            
            public static string ProductName = @"ProductName";
            
            public static string ProductSales = @"ProductSales";
            
            public static string ShippedQuarter = @"ShippedQuarter";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}