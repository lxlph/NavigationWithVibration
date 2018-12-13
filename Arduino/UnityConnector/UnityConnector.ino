unsigned long last_time = 0;

void setup()
{
    Serial.begin(9600);
    pinMode(D3, OUTPUT);
    pinMode(D1, OUTPUT);
}

void loop()
{
    // Print a heartbeat
    if (millis() > last_time + 2000)
    {
        Serial.println("Arduino is dead!!");
        last_time = millis();
    }

    // Send some message when I receive an 'A' or a 'Z'.
    switch (Serial.read())
    {
        case 'A':
            Serial.println("That's the first letter of the abecedarium.");
            digitalWrite(D3, HIGH); // LED anschalten
            digitalWrite(D1, HIGH); // LED anschalten
            break;
        case 'Z':
            digitalWrite(D3, LOW); // LED ausschalten
            digitalWrite(D1, LOW); // LED ausschalten
            Serial.println("That's the last letter of the abecedarium.");
            break;
    }
}
