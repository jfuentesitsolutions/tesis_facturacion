﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace conexiones_BD.clases.ventas
{
    public class detalles_productos_venta_factura:entidad
    {
        string iddetalle, idpresentacion_producto, cantidad, precio_venta, total, utilidad, 
            idventa_factura, descuento_iva, codigo, idsucursal_producto, cantidad_paquete;

        public string Idventa_factura
        {
            get
            {
                return idventa_factura;
            }

            set
            {
                idventa_factura = value;
            }
        }

        public detalles_productos_venta_factura(string iddetalle, string idpresentacion_producto, 
            string cantidad, string precio_venta, string total, string utilidad, string idventa_factura, 
            string descuento_iva, string codigo, string idsucursal_producto, string cantidad_paquete)
        {
            this.iddetalle = iddetalle;
            this.idpresentacion_producto = idpresentacion_producto;
            this.cantidad = cantidad;
            this.precio_venta = precio_venta;
            this.total = total;
            this.utilidad = utilidad;
            this.Idventa_factura = idventa_factura;
            this.descuento_iva = descuento_iva;
            this.codigo = codigo;
            this.idsucursal_producto = idsucursal_producto;
            this.cantidad_paquete = cantidad_paquete;
        }

        public override List<string> generarCampos()
        {
            List<string> campos = new List<string>();
            campos.Add("idpresentacion_producto");
            campos.Add("cantidad");
            campos.Add("precio_venta");
            campos.Add("total");
            campos.Add("utilidad");
            campos.Add("idventa_factura");
            campos.Add("descuento_iva");
            campos.Add("codigo");
            campos.Add("idsucursal_producto");
            campos.Add("cantidad_paquete");

            return campos;
        }

        public override List<string> generarValores()
        {
            List<string> campos = new List<string>();
            campos.Add(idpresentacion_producto);
            campos.Add(cantidad);
            campos.Add(precio_venta);
            campos.Add(total);
            campos.Add(utilidad);
            campos.Add(idventa_factura);
            campos.Add(descuento_iva);
            campos.Add(codigo);
            campos.Add(idsucursal_producto);
            campos.Add(cantidad_paquete);

            return campos;
        }

        public string ingresarProducto()
        {
            base.cargarDatos(generarCampos(), generarValores(), "detalles_ventas_factura");
            return sentenciaIngresar();
        }

        public static DataTable detalle_proTic(string id)
        {
            DataTable Datos = new DataTable();
            String Consulta;
            Consulta = @"select dvt.cantidad_paquete, p.nombre_presentacion, 
                        pr.nom_producto,  pp.precio, dvt.total, vt.fecha, vt.correlativo, vt.monto_total_neto, 
                        vt.efectivo, vt.cambio, ci.contenido, concat(cll.nombre_cliente,' ',cll.apellidos_cliente) as nombre,
                        cll.direccion, corr.inicio, corr.final, vt.idcorrelativo, codi.codigo as cod_producto, sp.kardex
                        from ventas v, ventas_tickets vt, detalles_ventas_ticket dvt, presentaciones_productos pp, sucursales_productos sp, 
                        presentaciones p, productos pr, citas ci, clientes cll, correlativos_ticket corr, codigos codi, productos_codigos proco
                        where v.idventa = vt.correlativo
                        and proco.idproducto=pr.idproducto
                        and proco.idcodigo=codi.idcodigo
                        and dvt.idventa_ticket = vt.correlativo
                        and dvt.idpresentacion_producto = pp.idpresentacion_producto
                        and pp.idsucursal_producto = sp.idsucursal_producto
                        and sp.idproducto = pr.idproducto
                        and pp.idpresentacion = p.idpresentacion
                        and dvt.idventa_ticket = '"+id+ @"' and vt.idcita=ci.idcita and vt.idcliente=cll.idcliente and vt.idcorrelativo = corr.idcorrelativo_ticket
                        and dvt.codigo=codi.codigo
                        and codi.estado=1                        
                        ; ";

            conexiones_BD.operaciones oOperacion = new conexiones_BD.operaciones();
            try
            {
                Datos = oOperacion.Consultar(Consulta);
            }
            catch
            {
                Datos = new DataTable();
            }

            return Datos;
        }
    }
}
