namespace CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates
{
    public class Sale
    {
        ///<summary>
        ///Identificador unico de la tabla completa
        /// </summary>
        public int Id { get; set; }
        ///<summary>
        /// numero de documento del cliente
        /// </summary>
        public String Document { get; set; }
        ///<summary>
        ///Correo Electornico 
        /// </summary>
        public String Email { get; set; }= null!;
        ///<summary>
        ///Los productos vendidos en la factura
        /// </summary>
        public virtual ICollection<ItemSale> ItemSales { get; set; } = null!;

    }
}
