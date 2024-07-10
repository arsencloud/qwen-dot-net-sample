# Alibaba Cloud Model Studio Integration with C# Console Application

This project demonstrates how to test Alibaba Cloud Model Studio and integrate it with a C# console application. The qwen-turbo model is used to create a simple assistant.

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This project showcases the integration of Alibaba Cloud Model Studio with a C# console application. The qwen-turbo model is utilized to develop a simple assistant capable of responding to user queries.

For more information, please refer to this article:
```url
https://www.alibabacloud.com/help/en/model-studio/developer-reference/qwen-model-api-details?spm=a2c63.p38356.0.0.7d8874a1VcqNyO
```

## Prerequisites

Before you begin, ensure you have met the following requirements:
- You have an Alibaba Cloud account and have access to Alibaba CloudModel Studio.
- You have generated an API Key and setup your account role through Alibaba Cloud Model Studio.
- Visual Studio 2017 IDE or later (Community Edition)
- Newtonsoft.JSON & RestSharp

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/arsencloud/qwen-dot-net-sample.git
    ```

2. Navigate to the project directory
3. Open the .sln file


## Usage

1. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).

2. Configure the Alibaba Cloud credentials and Model Studio settings in the `appsettings.json` file:

    ```
    string apiKey = "CHANGE YOUR DASHSCOPE API KEY HERE";
    ```

3. Run the application:


4. Interact with the assistant through the console interface.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
