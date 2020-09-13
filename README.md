# Encrypt/Decrypt Example

Encrypt/Decrypt Example for the Article [Cross Programming Language Encryption – CSharp, Part 1](https://lunaticthinker.me/index.php/cross-programming-language-encryption-csharp-part-1/).

![.NET Framework Version](https://img.shields.io/badge/.NET-4.6.1-brightgreen)
[![TravisCI](https://travis-ci.org/lunaticthinker-me/demo-cross-lang-encryption-cs.svg?branch=master)](https://travis-ci.org/lunaticthinker-me/demo-cross-lang-encryption-cs)
[![Contributions welcome](https://img.shields.io/github/contributors/lunaticthinker-me/demo-cross-lang-encryption-cs)](https://img.shields.io/github/contributors/lunaticthinker-me/demo-cross-lang-encryption-cs)

[![Sonarcloud Status](https://sonarcloud.io/api/project_badges/measure?project=lunaticthinker-me_demo-cross-lang-encryption-cs&metric=alert_status)](https://sonarcloud.io/dashboard?id=lunaticthinker-me_demo-cross-lang-encryption-cs)
[![SonarCloud Bugs](https://sonarcloud.io/api/project_badges/measure?project=lunaticthinker-me_demo-cross-lang-encryption-cs&metric=bugs)](https://sonarcloud.io/component_measures/metric/reliability_rating/list?id=lunaticthinker-me_demo-cross-lang-encryption-cs)
[![SonarCloud Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=lunaticthinker-me_demo-cross-lang-encryption-cs&metric=vulnerabilities)](https://sonarcloud.io/component_measures/metric/security_rating/list?id=lunaticthinker-me_demo-cross-lang-encryption-cs)

[![Donate to this project using Patreon](https://img.shields.io/badge/patreon-donate-yellow.svg)](https://patreon.com/dragoscirjan)
[![Donate to this project using Paypal](https://img.shields.io/badge/paypal-donate-yellow.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=UMMN8JPLVAUR4&source=url)

<!--
[![Donate to this project using Flattr](https://img.shields.io/badge/flattr-donate-yellow.svg)](https://flattr.com/profile/balupton)
[![Donate to this project using Liberapay](https://img.shields.io/badge/liberapay-donate-yellow.svg)](https://liberapay.com/dragoscirjan)
[![Donate to this project using Thanks App](https://img.shields.io/badge/thanksapp-donate-yellow.svg)](https://givethanks.app/donate/npm/badges)
[![Donate to this project using Boost Lab](https://img.shields.io/badge/boostlab-donate-yellow.svg)](https://boost-lab.app/dragoscirjan/badges)
[![Donate to this project using Buy Me A Coffee](https://img.shields.io/badge/buy%20me%20a%20coffee-donate-yellow.svg)](https://buymeacoffee.com/balupton)
[![Donate to this project using Open Collective](https://img.shields.io/badge/open%20collective-donate-yellow.svg)](https://opencollective.com/dragoscirjan)
[![Donate to this project using Cryptocurrency](https://img.shields.io/badge/crypto-donate-yellow.svg)](https://dragoscirjan.me/crypto)
[![Donate to this project using Paypal](https://img.shields.io/badge/paypal-donate-yellow.svg)](https://dragoscirjan.me/paypal)
[![Buy an item on our wishlist for us](https://img.shields.io/badge/wishlist-donate-yellow.svg)](https://dragoscirjan.me/wishlist)
-->

- [Encrypt/Decrypt Example](#encryptdecrypt-example)
  - [Compatibility](#compatibility)
  - [Getting Started](#getting-started)
    - [Prereqiusites / Dependencies](#prereqiusites--dependencies)
    - [Installation](#installation)
    - [Development](#development)
      - [Requirements](#requirements)
        - [For Windows](#for-windows)
        - [For Linux/Unix/OSX](#for-linuxunixosx)
    - [Testing](#testing)
    - [Running](#running)
  - [Authors](#authors)
  - [Issues / Support](#issues--support)

<!-- /TOC -->

## Compatibility

| Algorithm / Language (Go) | C# | Go | Js | Py |
| AES/CFB | ? | ? | ? | ? |
| AES/CFB8 | ✓ | ✕ | ✓ | ✓ |
| AES/CBC | ✓ | ✓ | ✓ | ✓ |
| RSA/OAEP | ✓ | ✕ | ✓ | ✓ |
| RSA/PCKS1V15 | ✓ | ✓ | ✓ | ✓ |

## Getting Started

### Prereqiusites / Dependencies

Have [openssl]() installed.

### Installation

```bash
git clone https://github.com/lunaticthinker-me/demo-cross-lang-encryption-cs
```

### Development

#### Requirements

- Please install a C# IDE
  - [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)
  - [Mono Develop](https://www.monodevelop.com/)

##### For Windows

- Please install [git-scm](https://git-scm.com/download/win) tool.

##### For Linux/Unix/OSX

- Please install `git`

```bash
sudo apt-get install git -y
```

### Testing

Run unit tests using `make test`.

### Running

Please run `make run`
Demo output:

```
AES Encrypted Values:
CFB 128 => byuCTbdRr+ypozUmNa5RjEUlCwvKMzLHb2TVEqiYFJo=
CFB 192 => bXd/eYTJpyFy53PawFW5LzPIGjbdQL/RrE8rz1BwYD0=
CFB 256 => bED7+lp70X533ISjLScRYe7hgEFddreAGBoIr5gBLxM=
CBC 128 => uf0v6GuYKU1gw8LTQl47vAdpDcyyumxL8xvHoE7rdVjxeinGZRFYwMmwwI2H1fZU
CBC 192 => jiDv5Twu6SQ9wMA0F5+2+dOGvfRAxzKZpMillk/HSIFbxQe6JtkVXUUqCqjUswUR
CBC 256 => 5QeOHaKlc+xPlVBVJTEx8Ms3I0at4B+OEQJxrJWHK4MEqnCuvYyxmryMTOmf1Q8H

RSA Encrypted Values:
IEJA5YH/aiC8ITEOiXZh/mBVeu079BGojI+DwXn84jbYH4KvkkNBUnLEksLoaSS5dUdlmf51J7tbSZml5oC/Z+NMyEsFC6qDX6zyPQ0cq7Xk94h9g67crdAQJH91XeQeKN1XCy9hauDqYs/PjnK39AmI14gSpvE5JGbEZButz9FWJYVlAkFZXf4A0qMJDyzjF//m+a8ItUw1axEknF6dEMLQb4LOo3UZMdErXbxgmDBi+KNbqtJrRXhkAodRJbnsFM0TtJ0k0GuW2VAXIDvTjNT+xn8cQMxGHOOEtPCcxTE8Pa0XPiwn8lERyINt429OmGFxLLoMkg9NpVyQfV8dDg==

X509 Encrypted Values:
YQdAkjJWHOvc6pJ1Ac+bKCJ16JMO2fPrLYQnbcOmHw9wNK0RGVgwJpTIVJdlK8xGGj41FPE5VKRev/yZAyfEC8LQisTgCCQY7Pm+Uuzm1CmjlI2RiIqNW0H+IdcN1RJYs21tpH6wrmkl9Yxyfa+PTA5UcJXW6+m0DeuUEK/ICsR2zteXrXHoZp9pGNLG+A4SRLFFFQFXfcrdAQHOd06phYtEbXMsR1/mwAXI/5brWt8A9ko3zdfNeRVe16ZPVQCDNEQBP9mjoemJBqcqX97NJ/c5DZ6BbOwWBxtaAGzvCGsWFQrXKTPCSs9vfgG15W428tL5WKxRsoiDtEElDDz23g==
```

## Authors

- [Dragos Cirjan](mailto:dragos.cirjan@gmail.com) - Initial work

## Issues / Support

Add a set of links to the [issues](/lunaticthinker-me/demo-cross-lang-encryption-cs/issues) page/website, so people can know where to add issues/bugs or ask for support.

<!-- ## Changelog

Small changelog history. The rest should be added to [CHANGELOG.md](CHANGELOG.md).

See here a template for changelogs: https://keepachangelog.com/en/1.0.0/

Also see this tool for automatically generating them: https://www.npmjs.com/package/changelog -->
