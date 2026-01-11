import { ProductsTable } from "../components/ProductsTable"

export const HomePage: React.FC = () => {
    return <div>
        <h1>Welcome, Admin!</h1>
        <p>You have successfully logged in.</p>
        <ProductsTable />
    </div>
}