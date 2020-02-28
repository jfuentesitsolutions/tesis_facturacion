using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexiones_BD.clases.ventas
{
    public class facturas : ventas
    {
        string numero_factura, idforma_pago, idsucursal, fecha_expedicion, fecha_operacion, idtipo_factura, 
            idusuario, sub_total, descuento_total, descuento_iva, descuento_renta, moneda, idcliente, 
            total_ventas_exentas, total_ventas_sujetas, total, metodo_pago, version, resolucion, 
            lugar_expedicion, cantidad_letras, num_factura_numero, nom_per_entrega, nom_pre_recibe, 
            nit_per_entrega, nit_per_recibe, dui_per_entrega, dui_per_recibe, num_cheque, num_transaccion;

        public string Numero_factura
        {
            get
            {
                return numero_factura;
            }

            set
            {
                numero_factura = value;
            }
        }

        public facturas(string idventa, string idventa_factura, string idsucursal, string anulacion, string idcaja, 
            string numero_factura, string idforma_pago, string fecha_expedicion, string fecha_operacion,
            string idtipo_factura, string idusuario, string sub_total, string descuento_total, 
            string descuento_iva, string descuento_renta, string moneda, string idcliente, 
            string total_ventas_exentas, string total_ventas_sujetas, string total, string metodo_pago, 
            string version, string resolucion, string lugar_expedicion, string cantidad_letras, 
            string num_factura_numero, string nom_per_entrega, string nom_pre_recibe, string nit_per_entrega, 
            string nit_per_recibe, string dui_per_entrega, string dui_per_recibe, string num_cheque, string num_transaccion)
            : base(idventa, idventa_factura, fecha_expedicion, idsucursal, anulacion, idcaja)
        {
            this.Numero_factura = numero_factura;
            this.idforma_pago = idforma_pago;
            this.idsucursal = idsucursal;
            this.fecha_expedicion = fecha_expedicion;
            this.fecha_operacion = fecha_operacion;
            this.idtipo_factura = idtipo_factura;
            this.idusuario = idusuario;
            this.sub_total = sub_total;
            this.descuento_total = descuento_total;
            this.descuento_iva = descuento_iva;
            this.descuento_renta = descuento_renta;
            this.moneda = moneda;
            this.idcliente = idcliente;
            this.total_ventas_exentas = total_ventas_exentas;
            this.total_ventas_sujetas = total_ventas_sujetas;
            this.total = total;
            this.metodo_pago = metodo_pago;
            this.version = version;
            this.resolucion = resolucion;
            this.lugar_expedicion = lugar_expedicion;
            this.cantidad_letras = cantidad_letras;
            this.num_factura_numero = num_factura_numero;
            this.nom_per_entrega = nom_per_entrega;
            this.nom_pre_recibe = nom_pre_recibe;
            this.nit_per_entrega = nit_per_entrega;
            this.nit_per_recibe = nit_per_recibe;
            this.dui_per_entrega = dui_per_entrega;
            this.dui_per_recibe = dui_per_recibe;
            this.num_cheque = num_cheque;
            this.num_transaccion = num_transaccion;
            base.cargarDatos(generarCampos(), generarValores(), "ventas_factura");
        }

        public facturas(string idventa, string anulado):base(idventa, anulado)
        {

        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("numero_factura");
            campos.Add("idforma_pago");
            campos.Add("idsucursal");
            campos.Add("fecha_expedicion");
            campos.Add("fecha_operacion");
            campos.Add("idtipo_factura");
            campos.Add("idusuario");
            campos.Add("sub_total");
            campos.Add("descuento_total");
            campos.Add("descuento_iva");
            campos.Add("descuento_renta");
            campos.Add("moneda");
            campos.Add("idcliente");
            campos.Add("total_ventas_exentas");
            campos.Add("total_ventas_sujetas");
            campos.Add("total");
            campos.Add("metodo_pago");
            campos.Add("version");
            campos.Add("resolucion");
            campos.Add("lugar_expedicion");
            campos.Add("cantidad_letras");
            campos.Add("num_factura_numero");
            campos.Add("nom_per_entrega");
            campos.Add("nom_pre_recibe");
            campos.Add("nit_per_entrega");
            campos.Add("nit_per_recibe");
            campos.Add("dui_per_entrega");
            campos.Add("dui_per_recibe");
            campos.Add("num_cheque");
            campos.Add("num_transaccion");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> valores = new List<string>();
            valores.Add(this.Numero_factura);
            valores.Add(this.idforma_pago);
            valores.Add(this.idsucursal);
            valores.Add(this.fecha_expedicion);
            valores.Add(this.fecha_operacion);
            valores.Add(this.idtipo_factura);
            valores.Add(this.idusuario);
            valores.Add(this.sub_total);
            valores.Add(this.descuento_total);
            valores.Add(this.descuento_iva);
            valores.Add(this.descuento_renta);
            valores.Add(this.moneda);
            valores.Add(this.idcliente);
            valores.Add(this.total_ventas_exentas);
            valores.Add(this.total_ventas_sujetas);
            valores.Add(this.total);
            valores.Add(this.metodo_pago);
            valores.Add(this.version);
            valores.Add(this.resolucion);
            valores.Add(this.lugar_expedicion);
            valores.Add(this.cantidad_letras);
            valores.Add(this.num_factura_numero);
            valores.Add(this.nom_per_entrega);
            valores.Add(this.nom_pre_recibe);
            valores.Add(this.nit_per_entrega);
            valores.Add(this.nit_per_recibe);
            valores.Add(this.dui_per_entrega);
            valores.Add(this.dui_per_recibe);
            valores.Add(this.num_cheque);
            valores.Add(this.num_transaccion);

            return valores;
        }

        public override List<string> campos()
        {
            List<string> campos = new List<string>();
            campos.Add("idventa");
            campos.Add("num_factura");
            campos.Add("fecha");
            campos.Add("idsucursal");
            campos.Add("anulacion");
            campos.Add("idcaja");

            return campos;
        }

        public override List<string> valores()
        {
            List<string> valores = new List<string>();
            valores.Add(idventa);
            valores.Add(base.idDocu);
            valores.Add(base.fecha);
            valores.Add(base.idsucursal);
            valores.Add(base.Anulacion);
            valores.Add(base.idcaja);

            return valores;
        }
    }
}
