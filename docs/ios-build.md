# Build the iPhone app with GitHub Actions

The `Build Hangman for iPhone` workflow builds a signed `.ipa` on a hosted macOS runner. Run it from **GitHub → Actions → Build Hangman for iPhone → Run workflow**. When it succeeds, download **Hangman-iOS-IPA** from the run's Artifacts section.

## One-time Apple setup

To install the IPA on a phone, create an Apple Development signing certificate and an iOS App Development provisioning profile in the Apple Developer account. Register the iPhone in that account and include it in the profile. The profile's App ID must match the bundle ID configured for this app. Apple account membership and provisioning options determine whether you can install on a device and how long the app remains available; distribution to other people requires the appropriate Apple Developer Program membership and signing profile.

Export the signing certificate as a password-protected `.p12` file. Encode the certificate and provisioning profile as Base64 and save them as GitHub Actions secrets:

- `APPLE_CERTIFICATE_P12_BASE64`
- `APPLE_CERTIFICATE_PASSWORD`
- `APPLE_PROVISIONING_PROFILE_BASE64`
- `APPLE_SIGNING_IDENTITY` — the full identity shown by Keychain, such as `Apple Development: Your Name (TEAMID)`
- `APPLE_TEAM_ID` — the 10-character Apple Developer Team ID

Set this GitHub Actions repository variable:

- `IOS_BUNDLE_ID` — a unique reverse-domain identifier registered for the app, for example `com.yourname.hangman`

For Base64 encoding on Windows PowerShell, run these commands locally and paste each clipboard value into its corresponding GitHub secret:

```powershell
[Convert]::ToBase64String([IO.File]::ReadAllBytes("C:\path\to\certificate.p12")) | Set-Clipboard
[Convert]::ToBase64String([IO.File]::ReadAllBytes("C:\path\to\profile.mobileprovision")) | Set-Clipboard
```

Run the first command, add the clipboard value as `APPLE_CERTIFICATE_P12_BASE64`, then run the second and add it as `APPLE_PROVISIONING_PROFILE_BASE64`. Keep the certificate password and signing details in GitHub Secrets; do not commit them to the repository.

The IPA is signed for the devices included in that development profile. Installing it is a separate iOS step; the IPA cannot simply be opened from the Files app. For broad distribution, use App Store Connect/TestFlight signing and distribution instead.
