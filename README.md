# Segundo Parcial — Concurso (U5-U7)
 
**Asignatura:** Fundamentos de Programación
**Docente:** Cristian E. Sánchez Ramírez
**Sección 7:** TDS-002-C3-2026

## Integrantes:
|-| Jade Mariel Mateo Baez - 20260706

# Ronda 3: Programa en vivo
El reto se encuentra en la carpeta [SegundoParcial](./SegundoParcial).

## Descripción
Sistema de compras para estudiantes con un menú interactivo. El usuario consulta un catálogo de accesorios tecnológicos, selecciona porductos y paga. El descuento de estudiante se aplica automáticamente según el monto de la compra.

### Opciones del menú
 
1. Ver catálogo
2. Agregar producto
3. Pagar
0. Salir

### Cupones disponibles
 
- 5 % en cualquier compra.
- 10 % en compras desde RD$ 1,500.
- 15 % en compras desde RD$ 3,000.

### Conceptos usados
 
- **Decisiones:** `if / else if / else` (descuento), `&&`, `switch` (menú y productos), `int.TryParse` y `double.TryParse`.
- **Ciclos:** `do-while` (menú, agregar productos y pago), `while` (validaciones), `for` (catálogo y cálculos), `continue` (omite productos no comprados).
- **Métodos:** `void`, parámetros, `return`, sobrecarga (`Linea()` y `Linea(int)`), variables locales y variables de clase (carrito).

## Cómo ejecutar
```bash
cd SegundoParcial/SistemaDeCompras
dotnet run
```

