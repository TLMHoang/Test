# Capstone project : Product Management API

This API allows you to manage products and their associated serial numbers (IMEIs). It provides endpoints for creating, reading, updating, and deleting products, as well as managing the serial numbers linked to each product.

## Motivation

The primary goal of this project is to provide a robust and scalable solution for managing product inventory and tracking individual items using unique serial numbers. This is crucial for businesses that need to maintain accurate records of their products, track warranty information, and manage returns or repairs.

## Hosted API

This API is not currently hosted on a public URL. However, it can be easily deployed to various cloud platforms or run locally for development and testing purposes.

## Project Dependencies

The project relies on the following key dependencies:

Flask: A lightweight and flexible web framework for building APIs.
Flask-Migrate: An extension for handling database migrations.
Flask-SQLAlchemy: An ORM for interacting with the database.
PostgreSQL: The database used to store product and serial data.
python-dotenv: For loading environment variables from a .env file.
Auth0: For authentication and authorization (JWT-based).

### Authentication

Most endpoints require authentication using a JSON Web Token (JWT). You'll need to include a valid JWT in the Authorization header of your requests. The JWT should be in the format "Bearer <your_jwt>".

### Error Handling

The API returns standard HTTP status codes to indicate the success or failure of requests. Common error codes include:

- 400 Bad Request: The request was invalid or malformed.
- 401 Unauthorized: The request lacked valid authentication credentials.
- 404 Not Found: The requested resource was not found.
- 405 Method Not Allowed: The requested HTTP method is not supported for the endpoint.
- 422 Unprocessable Entity: The request was well-formed but unable to be followed due to semantic errors.
- 500 Internal Server Error: An unexpected error occurred on the server.

### Endpoints

#### GET /products
- Fetches a list of all products.
- For each product, it includes the product ID, name, and the number of associated serial numbers.
- Requires authentication: No

#### GET /products/<id>
- Retrieves details of a specific product by its ID.
- Includes the product name and a list of all associated serial numbers (IMEIs).
- Requires authentication: Yes (requires 'get:products-detail' permission)

#### POST /products
- Creates a new product.
- Requires a JSON body with the product name (e.g., {"name": "Product X"}).
- Returns the details of the newly created product.
- Requires authentication: Yes (requires 'post:products' permission)

#### PATCH /products/<id>
- Updates an existing product by its ID.
- Requires a JSON body with the fields to update (e.g., {"name": "New Product Name"}).
- Returns the details of the updated product.
- Requires authentication: Yes (requires 'patch:products' permission)

#### DELETE /products/<id>
- Deletes a product by its ID.
- Returns the ID of the deleted product.
- Requires authentication: Yes (requires 'delete:products' permission)

#### POST /CreateProducts
- Creates a new product and associated serial numbers (IMEIs).
- Requires a JSON body with the product name and an array of IMEIs (e.g., {"name": "Product Z", "imeis": ["123456789012345", "987654321098765"]}).
- Returns the details of the created product and the successfully created serial numbers.
- Requires authentication: Yes (requires 'post:products' permission)



