import React from "react";
import { LoginForm } from "./components/LoginForm";
import { HomePage } from "./pages/Home";

interface AppState {
    isAdminLoggedIn: boolean;
    loginForm: {
        username: string;
        password: string;
    }
}

export const App: React.FC = () => {
    const [state, setState] = React.useState<AppState>({
        isAdminLoggedIn: false,
        loginForm: {
            username: "",
            password: ""
        }
    });

    if (!state.isAdminLoggedIn) {
        return <LoginForm
            onLoginSuccess={() => setState({ ...state, isAdminLoggedIn: true })}
            onLoginFailure={() => alert("Invalid credentials")}
        />
    }

    return <HomePage />
}