export const ProductsTable: React.FC = () => {
    return <div>
        <h2>Products</h2>
        <table border={1}>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Supplier</th>
                    <th>Stock</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Laptop</td>
                    <td>$999.99</td>
                    <td>Supplier A</td>
                    <td>10</td>
                    <td>
                        <button>Edit</button>
                        <button>Delete</button>
                        <button>View Details</button>
                    </td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Mouse</td>
                    <td>$29.99</td>
                    <td>Supplier B</td>
                    <td>50</td>
                    <td>
                        <button>Edit</button>
                        <button>Delete</button>
                        <button>View Details</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
}