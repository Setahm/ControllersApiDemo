# 🚀 ASP.NET Core Web API – Two Controllers Demo

A simple educational project built using **ASP.NET Core Web API**, demonstrating how to create an API that includes two controllers, each providing three essential operations:  
**POST – GET – DELETE**
---

## 📦 Project Structure

### 🧩 1. ProductsController  
Handles product-related operations:

- **POST /api/products**  
  Add a new product.

- **GET /api/products**  
  Retrieve all products.

- **DELETE /api/products/{id}**  
  Delete a product by ID.

---

### 🧩 2. CustomersController  
Handles customer-related operations:

- **POST /api/customers**  
  Add a new customer.

- **GET /api/customers**  
  Retrieve all customers.

- **DELETE /api/customers/{id}**  
  Delete a customer by ID.

---

## 🧪 Testing Example

### ✔️ Add a Customer (POST)
```json
{
  "id": 1,
  "name": "Setah",
  "email": "setah9@gmail.com"
}
