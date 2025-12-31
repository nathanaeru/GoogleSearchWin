# Google Search for Windows Start Menu (Unofficial)

A lightweight, open-source integration that replaces Bing with Google directly inside the Windows 10/11 Start Menu.

When you type in your Start Menu and press Enter, it launches your default browser (Chrome, Edge, Firefox) with Google search results instead of opening Edge with Bing.

> **Disclaimer:** This software is an independent personal project. It is **not** affiliated with, endorsed by, or connected to Google LLC or Microsoft Corporation.

## Important: Requirements

To use this custom search provider, **Microsoft requires your Windows Region to be set to an EEA (European Economic Area) country.** This is due to the Digital Markets Act (DMA).

- **Supported OS:** Windows 10 (latest updates) or Windows 11.
- **Required Region:** Austria, Belgium, France, Germany, Iceland, Ireland, Italy, Netherlands, Norway, Poland, Sweden, etc.
  - _Note: You do not need to change your Display Language, only the Region Format in Settings._

## How to enable EEA settings without changing the region

> **Note:** This is an unofficial method and may prone to breaking. Do at your own risk.

- Download and install [**Wintoys**](https://bogdan-patraucean.github.io/about/wintoys/)
- Open it, go to **Tweaks > System**
- Enable the **Digital markets act** switch.
- Restart your system.
- This change may be reverted after system updates. In that case, you need to do these steps again.

## How to Download

Get one from the [release](https://github.com/nathanaeru/google-search-win/releases/latest) page.

## How to Install

Because this is a free, personal app (and not one downloaded from the Microsoft Store), it uses a self-signed certificate. Windows will not install it unless you tell it to trust the certificate first.

### Step 1: Certificate Installation (Required)

You must do this **once** before installing.

1.  Right-click the **`GoogleSearch.appx`** file and select **Properties**.
2.  Go to the **Digital Signatures** tab.
3.  Select the signature in the list (`NathaNaeru`) and click **Details**.
4.  Click **View Certificate** -> **Install Certificate**.
5.  Select **Local Machine** and click **Next** (Click Yes if prompted).
6.  Select **"Place all certificates in the following store"**.
7.  Click **Browse...** and select **Trusted People** (not "Trusted Root Certification Authorities").
8.  Click **OK** -> **Next** -> **Finish**.

You should see a message saying _"The import was successful."_

### Step 2: Install the App

1.  Now that the certificate is trusted, simply **double-click** the `GoogleSearch.appx` file.
2.  Click **Install**.
3.  The app is now registered on your system.

---

## How to Enable

Once installed, you must tell Windows to use it instead of Bing.

1.  Open Windows **Settings**.
2.  Go to **Privacy & security** -> **Search permissions**.
3.  Scroll down to the bottom to find the **Search Engine** section.
4.  In the dropdown menu, change "Bing" to **"Google Search"**.

_If you do not see this dropdown, verify that your Windows Region is set to an EEA country and restart your computer._

## Uninstallation

To remove the integration:

1.  Go to **Settings** -> **Apps** -> **Installed Apps**.
2.  Search for "Google Search".
3.  Click the `...` menu and select **Uninstall**.
4.  Windows will automatically revert to Bing (or ask you to select a provider).
