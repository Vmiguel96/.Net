/* EJERCICIO 1 */
SELECT nombre, edad
FROM empleados;

/* EJERCICIO 2*/
SELECT titulo, salario * 1.02 AS "salario aumentado", 
	trienio * 1.02 AS "trienio aumentado"
FROM categorias

/* EJERCICIO 3 */
SELECT num, nombre, contrato, YEAR(contrato) AS año,
MONTH (contrato) AS mes, DAY(contrato) AS dia
FROM empleados;

/* EJERCICIO 4*/
SELECT nombre, edad
FROM empleados;

/* EJERCICIO 5 */
SELECT titulo
FROM categorias
WHERE salario > 35000

/* EJERCICIO 6 */
SELECT *
FROM empleados
WHERE num = 1014

/* EJERCICIO 7 */

SELECT nombre, departamento
FROM empleados
WHERE departamento = 106

/* EJERCICIO 8 */
SELECT *
FROM empleados
WHERE YEAR(contrato) = 2000

SELECT * 
FROM empleados
WHERE contrato BETWEEN eoieoi AND '2000-12-31'

/* EJERCICIO 9 */
SELECT num, nombre, categoria
FROM empleados
WHERE categoria <> 4

/* EJERCICIO 10 */
SELECT num, nombre, contrato
FROM empleados
WHERE year(contrato) BETWEEN 1990 AND 1994

SELECT num, nombre, contrato
FROM empleados
WHERE contrato >= '1990-01-01' AND contrato <= '1994-12-31'


SELECT num, nombre, contrato
FROM empleados
WHERE year(contrato) >= 1990 AND year(contrato) <= 1994

SELECT num, nombre, contrato
FROM empleados
WHERE year(contrato) IN (1990,1991,1992,1993,1994)

/* EJERCICIO 11 */
SELECT titulo, salario
FROM categorias
WHERE salario < 35000 OR salario > 40000


SELECT titulo, salario
FROM categorias
WHERE salario NOT BETWEEN 35000 AND 40000

/* EJERCICIO 12 */
SELECT nombre, edad, categoria
FROM empleados
WHERE categoria = 1 OR categoria = 2
ORDER BY categoria ASC, nombre DESC

SELECT nombre, edad, categoria
FROM empleados
WHERE categoria IN (1,2) 
ORDER BY categoria ASC, nombre DESC

/* EJERCICIO 13 */
SELECT nombre
FROM empleados
WHERE nombre LIKE '%jose%'

/* EJERCICIO 14 */
SELECT nombre, categoria, edad
FROM empleados
where categoria = 3 AND edad > 35


/* EJERCICIO 15 */
SELECT * 
FROM empleados
WHERE departamento <> 110

/* EJERCICIO 16 */
SELECT nombre, edad
FROM empleados
ORDER BY edad

/* EJERCICIO 17 */
SELECT nombre, edad
FROM empleados
ORDER BY nombre DESC

/* EJERCICIO 18 */
SELECT nombre, titulo
FROM empleados e, categorias c
WHERE e.categoria = c.categoria
ORDER BY nombre

/* EJERCICIO 19 */
SELECT codigo, telefono
FROM dptoficinas d, oficinas o
WHERE d.oficina = o.oficina
AND region = 'Centro'


/* EJERCICIO 20 */
SELECT e.nombre, o.ciudad
FROM empleados e, dptoficinas d, oficinas o
WHERE e.departamento = d.codigo 
	AND d.oficina = o.oficina


/* EJERCICIO 21 */

/* EJERCICIO 22 */
SELECT e1.nombre, e2.nombre AS "JEFE SECCION", e1.departamento, e2.departamento, 
		e1.categoria, e2.categoria AS "CAT JEFE"
FROM empleados e1, empleados e2
WHERE e1.categoria NOT IN (1,2)
		AND e2.Categoria = 2
		AND e1.departamento = e2.departamento
		
/* EJERCICIO 23 */
SELECT SUM(salario) 
FROM empleados e, categorias c
WHERE e.categoria = c.categoria

/* EJERCICIO 24 */
Select avg(salario) as PromedioSalarios
from empleados, categorias, dptoficinas, oficinas
where dptoficinas.oficina=oficinas.oficina
AND empleados.departamento=dptoficinas.codigo
AND empleados.categoria= categorias.categoria
AND ciudad="Barcelona"


/* EJERCICIO 25 */ /*LO volveremos a hacer*/
SELECT MAX(salario+trienio), MIN(salario+trienio)
FROM empleados e, categorias c
WHERE e.categoria = c.categoria

/* EJERCICIO 26 */
SELECT count(*)
FROM empleados
WHERE edad > 40

/* mayores de 40 por categoria */
SELECT c.categoria, titulo, COUNT(*)
FROM empleados e, categorias c
WHERE edad>40
AND e.categoria = c.categoria
GROUP BY c.categoria, c.titulo

/* EJERCICIO 27 */
SELECT count(DISTINCT edad)
FROM empleados

/* ????? */	
SELECT COUNT(edad) AS edades
FROM empleados
GROUP BY edad

/* EJERCICIO 28 */
SELECT c.categoria, c.titulo, SUM(salario), COUNT(*)
FROM empleados e, categorias c
WHERE e.categoria = c.categoria
GROUP BY c.categoria, c.titulo

/* EJERCICIO 29 */
SELECT o.oficina, o.ciudad, SUM(salario), COUNT(*)
FROM empleados e, categorias c, oficinas o, dptoficinas dt
WHERE e.categoria = c.categoria
AND e.departamento = dt.codigo
AND dt.oficina = o.oficina
GROUP BY o.oficina, o.ciudad

/* EJERCICIO 30 */
SELECT c.categoria, c.titulo, SUM(salario), COUNT(*)
FROM empleados e, categorias c
WHERE e.categoria = c.categoria
GROUP BY c.categoria, c.titulo
HAVING SUM(salario) > 100000

/* EJERCICIO 31 */
SELECT deptno, d.nombre, COUNT(*)
FROM empleados e, dptoficinas dt, departamentos d
WHERE e.departamento = dt.codigo 
AND dt.departamento = d.deptno
GROUP BY deptno, d.nombre
HAVING COUNT(*) > 5

SELECT * 
FROM repventas INNER JOIN oficinas 
ON repventas.oficina_rep = oficinas.oficina

SELECT * 
FROM repventas, oficinas 
WHERE repventas.oficina_rep = oficinas.oficina