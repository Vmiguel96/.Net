SELECT 1
FROM DUAL;

SELECT * 
FROM clientes;

SELECT *
FROM oficinas;

SELECT *
FROM pedidos;

SELECT *
FROM clientes;


SELECT ciudad, region, ventas
FROM oficinas;

SELECT ciudad, region, (ventas-objetivo) as diferencia
FROM oficinas;

SELECT ciudad, ' tiene unas ventas de ', ventas
FROM oficinas;

SELECT nombre, contrato, DAY(contrato) AS dia, 
	MONTH(contrato) AS mes, YEAR(contrato) AS año
FROM repventas;

SELECT  DISTINCT region
FROM oficinas

SELECT nombre, contrato
FROM repventas
WHERE contrato <= '1998-01-01';

SELECT ciudad, ventas , objetivo, objetivo * 0.75 AS esperado
FROM oficinas
WHERE ventas <= objetivo * 0.75

SELECT nombre 
FROM repventas
WHERE	ventas <= cuota

SELECT * 
FROM pedidos
WHERE importe BETWEEN 22500 AND 27500

SELECT * 
FROM repventas
WHERE ventas BETWEEN (cuota*0.75) AND (cuota * 1.5)


SELECT num_empl, nombre, cuota, ventas
FROM repventas
WHERE oficina_rep NOT IN (11,13,22)

SELECT num_empl, nombre
FROM repventas
WHERE nombre LIKE '%Lorenzo%'

SELECT nombre
FROM repventas
WHERE oficina_rep IS NOT NULL

SELECT ciudad, region, (ventas-objetivo) AS resultado
FROM oficinas
ORDER BY resultado DESC

SELECT id_fab, id_producto 
FROM productos 
WHERE precio > 2000 
UNION 
SELECT DISTINCT fab, producto
FROM pedidos 
WHERE importe > 30000
ORDER BY 1,2


SELECT *
FROM clientes c, pedidos p
WHERE c.num_clie = p.clie

SELECT num_empl, edad, o.ciudad AS oficina, titulo, contrato, director, cuota, r.ventas
FROM repventas r, oficinas o
WHERE r.oficina_rep = o.oficina
AND objetivo > 60000



SELECT num_pedido, importe, pr.descripcion 
FROM pedidos pe , productos pr 
WHERE pe.fab = pr.id_fab 
/*		AND pe.producto = pr.id_producto */


SELECT e1.nombre, e2.nombre AS jefe
FROM repventas e1 LEFT join repventas e2
ON e1.director = e2.num_empl

SELECT COUNT(importe)
FROM pedidos


SELECT sum(ventas)-sum(objetivo) as diferencia
FROM oficinas;


SELECT SUM(importe) 
FROM pedidos p, repventas r
WHERE rep = num_empl
AND nombre = 'Belen Aguirre' 
 
 
 SELECT COUNT(*), COUNT(ventas), COUNT(cuota) 
 FROM repventas
 
 
 SELECT SUM(ventas), SUM(cuota), SUM(ventas)-SUM(cuota), SUM(ventas-cuota) 
 FROM repventas
 
 
 SELECT *
 FROM  pedidos
 
 SELECT rep, COUNT(*), avg(importe) AS media
 FROM pedidos
 GROUP BY rep
 
 
 SELECT oficina_rep,MIN(cuota), MAX(cuota), COUNT(*), SUM(cuota), AVG(cuota)
 FROM repventas 
 GROUP BY oficina_rep
 
 SELECT num_empl, nombre, SUM(importe) 
 FROM pedidos, repventas 
 WHERE rep = num_empl 
 GROUP BY num_empl
 
 
SELECT fab,producto, COUNT(*), SUM(importe)
from pedidos
GROUP BY fab, producto
ORDER BY COUNT(*) DESC


SELECT rep, avg(importe) 
FROM pedidos 
GROUP BY rep 
HAVING SUM(importe) > 30000


SELECT descripcion, precio, existencias, SUM(cant) 
FROM productos, pedidos 
WHERE fab = id_fab 
AND producto = id_producto 
GROUP BY id_fab, id_producto, descripcion, precio, existencias 
HAVING SUM(cant) > (0.75*existencias) 
ORDER BY existencias DESC

/***** FUNCIONES DE FECHA ********/

select now(), curdate(), CURTIME() FROM DUAL;

select dayname(fecha_pedido) día, dayofweek(fecha_pedido) mes, 
	monthname(fecha_pedido) año, fecha_pedido
FROM pedidos

select fecha_pedido, DATE_FORMAT(fecha_pedido,'%d/%m/%Y %T')
FROM pedidos



SELECT DATEDIFF('2007-12-31 23:59:59','2007-12-30 15:00:00') as resta;


SELECT nombre, contrato, 
salario + TRUNCATE(DATEDIFF(CURDATE(), contrato)/365/3,0) * trienio AS SUELDO
FROM empleados e, categorias c
WHERE e.categoria = c.categoria
ORDER BY 3 desc