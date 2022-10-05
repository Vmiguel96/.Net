/* 2.001 */
SELECT *
FROM usuario

/* 2.002 */
SELECT email, nombre, apellidos 
FROM usuario

/* 2.003 */
SELECT email, nombre, apellidos 
FROM usuario
ORDER BY email

/* 2.004 */
SELECT email, nombre, apellidos 
FROM usuario
ORDER BY apellidos, nombre

/* 2.005 */
SELECT email, nombre, apellidos 
FROM usuario
ORDER BY apellidos ASC, nombre DESC

SELECT apellidos, COUNT(*)
FROM usuario
GROUP BY apellidos
HAVING COUNT(*) > 1

/* 2.006 */
SELECT email, nombre, apellidos 
FROM usuario
ORDER BY apellidos DESC, nombre DESC

/* 2.007 */
SELECT DNI, email, nombre, apellidos 
FROM usuario
WHERE provincia = 33


/* 2.008 y 2.009 */
SELECT  distinct p.codp, p.nombre 
FROM provincia p, usuario u
WHERE u.provincia = p.codp
ORDER BY p.nombre

/* 2.010 */
SELECT u.nombre, apellidos, email, 'No tiene teléfono'
FROM usuario u, provincia p, localidad l
WHERE telefono IS NULL
AND u.pueblo = l.codm 
AND u.provincia = l.provincia
AND l.provincia = p.codp
AND p.nombre = 'Murcia'


SELECT u.nombre, apellidos, email, 'No tiene teléfono'
FROM usuario u, provincia p
WHERE u.provincia = p.codp
AND telefono IS NULL
AND p.nombre = 'Murcia'

/* 2.011 */
SELECT * 
FROM marca

/* 2.012 */
SELECT * 
FROM articulo
WHERE marca IS NULL


SELECT * 
FROM ptienea

/*2.014*/
SELECT p.cod, a.nombre, a.pvp
FROM pack p, articulo a
WHERE p.cod = a.cod

/*2.015*/
SELECT a.cod, a.nombre, a.marca
FROM ptienea p, articulo a
WHERE p.articulo = a.cod

/*2.016*/
SELECT articulo, importe
FROM linped
WHERE numPedido = 1

/*2.017 */
SELECT a.cod, a.nombre, a.marca, a.pvp, l.importe
FROM articulo a, linped l
WHERE a.cod = l.articulo
AND numPedido = 1

/*2.018*/
SELECT a.cod, a.nombre, a.marca, a.pvp, l.importe
FROM articulo a, linped l, tv t
WHERE a.cod = l.articulo
AND t.cod = a.cod
AND numPedido = 1


/*2.019*/
SELECT p.usuario, p.fecha, a.cod, a.nombre, a.marca, a.pvp, l.importe
FROM articulo a, linped l, tv t, pedido p
WHERE a.cod = l.articulo
AND t.cod = a.cod
AND p.numpedido = l.numPedido
AND l.numPedido = 1

/*2.021*/
SELECT cod, nombre, 'tiene precio de', pvp
FROM articulo
WHERE pvp < 100 

/*2.022*/
SELECT cod, sensor, pantalla
FROM camara
WHERE pantalla IS NOT NULL
ORDER BY cod DESC

/*2.023*/
SELECT distinct panel
FROM tv
WHERE pantalla <= 21

/*2.024 */
SELECT cod, nombre, marca, pvp
FROM articulo
WHERE pvp BETWEEN 350 AND 450

/*2.025 */
SELECT a1.cod ,a1.nombre, a1.pvp, a2.cod, a2.nombre, a2.pvp
FROM pack p, articulo a1, ptienea pt, articulo a2
WHERE p.cod = a1.cod
AND p.cod = pt.pack
AND pt.articulo = a2.cod


/*3.001*/
SELECT cod, nombre
FROM articulo
WHERE pvp > 400 AND pvp <500

SELECT cod, nombre
FROM articulo
WHERE pvp BETWEEN 400 AND 500


/* 3.002 */
SELECT cod, nombre, pvp
FROM articulo
WHERE pvp IN(415, 129, 1259, 3995)

SELECT cod, nombre, pvp
FROM articulo
WHERE pvp = 415 OR pvp = 129 OR pvp = 1259 OR pvp = 3995

/*3.003 */
SELECT codp, nombre
FROM provincia
WHERE nombre NOT IN ('Huelva','Sevilla','Asturias','Barcelona')

SELECT codp, nombre
FROM provincia
WHERE nombre != 'Huelva' 
AND nombre <> 'Sevilla' 
and nombre != 'Asturias'
and nombre <> 'Barcelona'


/* 3.004 */
SELECT codp
FROM provincia
WHERE nombre = 'Alicante'

SELECT codp
FROM provincia
WHERE nombre LIKE '%Alicante%'

/* 3.005 */
SELECT cod, nombre, pvp, marca
FROM articulo
WHERE marca LIKE 'S%'


/* 3.006 */
SELECT *
FROM usuario
WHERE email LIKE '%@eps.%'

/* 3.007 */
SELECT a.cod, nombre, resolucion, pantalla
FROM articulo a, tv t
WHERE a.cod = t.cod
AND pantalla NOT BETWEEN 22 AND 42
ORDER BY pantalla

/* 3.008 */
SELECT a.cod, nombre, resolucion, pantalla, panel, pvp
FROM articulo a, tv t
WHERE a.cod = t.cod
AND panel LIKE '%LED%'
AND panel NOT LIKE '%OLED%'
AND pvp <=1000

SELECT DISTINCT panel
FROM tv

/* 3.009 */
SELECT email
FROM usuario
WHERE codpos NOT IN ('02012','02018', '02032')

/* 3.010 */
SELECT distinct cod, nombre
FROM articulo a, ptienea p
WHERE a.cod = p.pack


/*3.011*/

SELECT c.*
FROM cesta c, articulo a, stock s
WHERE c.articulo = a.cod
AND a.cod = s.articulo
AND s.entrega LIKE '%Descatalogado%'


SELECT c.*, s.*
FROM cesta c, stock s
WHERE c.articulo = s.articulo
AND s.entrega LIKE '%Descatalogado%'

SELECT distinct entrega
FROM stock

/* 3.012 */
SELECT a.cod, nombre, pvp
FROM articulo a, camara c
WHERE a.cod = c.cod
AND tipo LIKE '%compacta%'

SELECT DISTINCT tipo
FROM camara

/* 3.013*/
SELECT cod, nombre, (pvp-importe) AS diferencia
FROM linped l, articulo a
WHERE l.articulo = a.cod
AND a.pvp <> l.importe

/* 3.014 */
SELECT p.numPedido,  fecha, nombre, apellidos
FROM usuario u, pedido p
WHERE u.email = p.usuario
AND apellidos LIKE '%MARTINEZ%'

/* 3.015 */

SELECT cod, nombre, marca, pvp
FROM articulo
WHERE pvp IN (SELECT MAX(importe)
					FROM linped)

/* 3.016*/
SELECT nombre, marca, resolucion
FROM articulo a, camara c
WHERE a.cod = c.cod
AND A.cod NOT IN 
				  (SELECT C1.cod
					FROM camara c1, linped l
					WHERE c1.cod = l.articulo)

/* 3.018*/

SELECT cod, nombre, pvp
FROM articulo a1, camara c1
WHERE c1.cod = a1.cod
AND tipo LIKE '%rÃ©flex%'
AND  pvp = (
  SELECT MAX(PVP)
  FROM articulo a, camara c
  WHERE a.cod = c.cod
  AND tipo LIKE '%rÃ©flex%')
 
/* 3.019 */
SELECT marca 
FROM marca
WHERE marca NOT IN (
SELECT a.marca
FROM articulo a, tv t
WHERE a.cod = t.cod)

SELECT marca
FROM marca m
WHERE NOT EXISTS (
SELECT 1
FROM articulo a, tv t
WHERE a.cod = t.cod
AND  a.marca = m.marca)

/*3.020*/
SELECT cod, nombre, disponible, s1.entrega
FROM articulo a, stock s1
WHERE a.cod = s1.articulo
AND s1.entrega LIKE '24 horas'
AND disponible =
	(SELECT min(disponible)
	FROM stock s
	WHERE s.entrega LIKE '24 horas')
	
	
/* 4.001*/
SELECT * 
FROM pedido
WHERE fecha < '2010-10-01'

/*4.002*/
SELECT * 
FROM pedido
WHERE fecha > '2010-08-31'

/* 4.003 */
SELECT *
FROM pedido
WHERE fecha BETWEEN '2010-08-01' AND '2010-10-31'


/* 4.004*/ 
SELECT *
FROM pedido
WHERE fecha = '2010-03-03' 
OR  fecha ='2010-10-27'


/* 4.005*/ 
SELECT *
FROM pedido
WHERE (fecha = '2010-03-03' OR  fecha ='2010-10-27')
AND usuario LIKE '%@cazurren%'


/* 4.006 */
SELECT NOW() FROM DUAL

/* 4.007 */
SELECT DATE_FORMAT('2011-02-21','%d/%m/%Y') FROM DUAL
/* 4.008 */
SELECT DATE_FORMAT('2011-02-31','%d/%m/%Y') FROM DUAL

/* 4.009 */
SELECT *
FROM pedido
WHERE fecha = DATE_FORMAT('2010-09-13','%d.%c.%Y')


SELECT *
FROM pedido
WHERE '13.9.2010' = DATE_FORMAT(fecha,'%d.%c.%Y')

/* 4.010 */

SELECT numPedido, DATE_FORMAT(fecha,'%d.%c.%Y') AS fecha
FROM pedido
WHERE '13.9.2010' = DATE_FORMAT(fecha,'%d.%c.%Y')

/*4.011 */
SELECT usuario, numPedido, DATE_FORMAT(fecha,'%d.%m.%y') AS fechaCalculada
FROM pedido
ORDER BY fecha DESC, usuario ASC

/* 4.012 */
SELECT distinct articulo
FROM linped l, pedido p
WHERE p.numPedido = l.NumPedido
AND YEAR(FECHA) = 2010
ORDER BY articulo

/* 4.013 */
SELECT distinct articulo
FROM linped l, pedido p
WHERE p.numPedido = l.NumPedido
AND YEAR(FECHA) = 2010
AND MONTH(fecha) = 3
ORDER BY articulo

/* 4.014 */
SELECT articulo, DATE_FORMAT(fecha,'%U') AS semana
FROM linped l, pedido p
WHERE p.numPedido = l.NumPedido
AND YEAR(FECHA) = 2010
AND MONTH(fecha) = 9
ORDER BY semana 
