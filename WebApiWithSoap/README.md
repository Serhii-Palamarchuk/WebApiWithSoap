SOAP call, where <tem:input> is a parameter of the method MySoapMethod

```xml
curl --location 'http://localhost:5000/MyService.svc' \
--header 'Content-Type: text/xml' \
--data '<?xml version="1.0" encoding="utf-8"?>
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:tem="http://tempuri.org/">
    <soapenv:Header/>
    <soapenv:Body>
        <tem:MySoapMethod>
            <tem:input>Serhii</tem:input>
        </tem:MySoapMethod>
    </soapenv:Body>
</soapenv:Envelope>'
```

SOAP response, where <MySoapMethodResult> is a result of the method MySoapMethod

```xml
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <s:Body>
    <MySoapMethodResponse xmlns="http://tempuri.org/">
      <MySoapMethodResult>Hello, Serhii</MySoapMethodResult>
    </MySoapMethodResponse>
  </s:Body>
</s:Envelope>
```