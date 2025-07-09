# 🛍️ E-Commerce System

A simple C# based e-commerce system that simulates real-world product management, shopping cart functionality, checkout process, and shipping service.

## 📦 Features

### 🛒 Product Management
- Define products with:
  - `name`
  - `price`
  - `quantity`
- Supports **perishable products** (e.g. Cheese, Biscuits) that can expire.
- Supports **non-perishable products** (e.g. TV, Mobile).
- Products may or may not be **shippable**:
  - Shippable products (e.g. Cheese, TV) must provide a `weight`.
  - Non-shippable products (e.g. Mobile recharge cards) do not require shipping.

### 🧍 Customer Interaction
- Customers can:
  - Add products to their cart with a desired quantity (must not exceed stock).
  - Checkout items in their cart.

### 💳 Checkout Process
- During checkout, the system:
  - Prints order details to the console:
    - Subtotal (sum of item prices × quantity)
    - Shipping fees
    - Total paid amount (subtotal + shipping fees)
    - Customer’s remaining balance
- Validates and handles errors:
  - ❌ Cart is empty
  - ❌ Customer balance is insufficient
  - ❌ Product is out of stock or expired

### Program Flow
  - **Start**
    
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20024705.png)
  - **Check User Cart**
      - Not have any products yet
    
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025022.png)
  - **Try Checkout**
    - Can not checkout before add some products.
       
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025038.png)
  - **Add A Product**
    
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025133.png)
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025200.png)
    - **We not have sufficent money to buy two iphones :(**
  - **Trying Add Another Product**
    - **what about butter! :)**
         
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025227.png)

    - **The user balance updated after adding the product to cart**
  - **Now We Can Check User Cart**
     
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025245.png)
  - **We Can Also Checkout :)**
    
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025303.png)
  - **Cart Back Empty :(**
      
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025400.png)
  - **We Can Not Adding Product More Than It's Available Quantity Although We Have Enough Money**
    - **Trying to buy 30 items of butter**
      
    ![image alt](https://github.com/Ras1an/E-Commerce-System/blob/master/Screenshot%202025-07-09%20025445.png)
