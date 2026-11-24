# Hangman WebAssembly

This is the standalone Blazor WebAssembly version of Hangman. It runs entirely in the browser and can be served as static files.

## Run locally

```powershell
dotnet run --project HangMan.Wasm
```

## Publish static files

```powershell
dotnet publish HangMan.Wasm -c Release -o publish
```

The static site is in `publish/wwwroot`. The repository's GitHub Actions workflow publishes that folder to GitHub Pages whenever a commit is pushed to `master`.

For the first deployment, set the repository's **Settings → Pages → Build and deployment → Source** to **GitHub Actions**.
