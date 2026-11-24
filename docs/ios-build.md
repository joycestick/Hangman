# Build the iPhone app with GitHub Actions

The Build Hangman for iPhone workflow builds a signed IPA on a hosted macOS runner. In the repository, open Actions, select Build Hangman for iPhone, then choose Run workflow. After it succeeds, download the Hangman-iOS-IPA artifact from that run.

## One-time Apple signing setup

Create an Apple Development signing certificate and an iOS App Development provisioning profile. Register the iPhone and include it in the profile. The profile App ID must match the bundle ID configured below. Apple account membership determines the provisioning and distribution options available to you.

Export the signing certificate as a password-protected P12 file. Add these in Settings → Secrets and variables → Actions → New repository secret:

- APPLE_CERTIFICATE_P12_BASE64
- APPLE_CERTIFICATE_PASSWORD
- APPLE_PROVISIONING_PROFILE_BASE64
- APPLE_SIGNING_IDENTITY — for example, Apple Development: Your Name (TEAMID)
- APPLE_TEAM_ID — the 10-character Team ID

Then add the repository variable IOS_BUNDLE_ID under Settings → Secrets and variables → Actions → Variables. It must be a unique reverse-domain identifier registered with Apple, such as com.yourname.hangman.

On Windows PowerShell, encode each file as Base64 and copy it to the matching secret:

    [Convert]::ToBase64String([IO.File]::ReadAllBytes("./certificate.p12")) | Set-Clipboard
    [Convert]::ToBase64String([IO.File]::ReadAllBytes("./profile.mobileprovision")) | Set-Clipboard

Run one command at a time and paste each clipboard value into its matching secret. Keep the P12 password in GitHub Secrets; never commit it or the certificate to the repository.

The resulting IPA is signed for devices listed in its development profile. iOS does not install an IPA by opening it from the Files app; install it through an Apple-supported development or distribution method. For distribution to other people, use an App Store Connect/TestFlight profile.
