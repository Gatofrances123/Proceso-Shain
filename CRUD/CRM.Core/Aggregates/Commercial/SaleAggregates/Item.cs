namespace CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates
{
    public class Item
    {
        /// <summary>
        /// Identificador de la tabla 
        /// </summary>
        public int Id { get; set; }
        ///<summary>
        ///Nombre del cliente 
        ///</summary> 
        public string Name { get; set; } = null!;
        ///<summary></summary>
        ///precio del producto 
        ///<summary></summary>
        public int price { get; set; }
        ///<summary>
        ///Cantidad de productos 
        ///</summary>
        public int Quantity { get; set; }
        ///<summary>
        ///Los productos vendidos en la factura 
        /// </summary>
        public virtual ICollection<ItemSale> ItemSales { get; set; } = null!;


    }
}
