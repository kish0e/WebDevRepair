import { useState } from "react";

const login = (username: string, password: string): Promise<boolean> => {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(username === "admin" && password === "password");
        }, 1000);
    });
}

interface LoginFormState {
    username: string;
    password: string;
}

interface LoginFormProps {
    onLoginSuccess: () => void;
    onLoginFailure: () => void;
}

export const LoginForm: React.FC<LoginFormProps> = ({ onLoginSuccess, onLoginFailure }) => {
    const [state, setState] = useState<LoginFormState>({
        username: "",
        password: ""
    });

    return <form onSubmit={async (e) => {
        e.preventDefault();
        const success = await login(state.username, state.password);
        if (success) {
            onLoginSuccess();
        } else {
            onLoginFailure();
        }
    }}>
        <h2>Admin Login</h2>
        <div>
            <label>Username:</label>
            <input type="text" name="username" value={state.username} onChange={(e) => setState({ ...state, username: e.target.value })} />
        </div>
        <div>
            <label>Password:</label>
            <input type="password" name="password" value={state.password} onChange={(e) => setState({ ...state, password: e.target.value })} />
        </div>
        <button type="submit">Login</button>
    </form>
}