unsigned long last_time = 0;

void setup()
{
    Serial.begin(9600);
    pinMode(D3, OUTPUT);
    pinMode(D1, OUTPUT);
}

void loop()
{
    // Send some message when I receive an letter
    switch (Serial.read())
    {
        case 'V':
            //vibrate left one-handed
            //Serial.println("That's the first letter of the abecedarium.");
            digitalWrite(D3, HIGH); // LED anschalten
            delay(500);
            digitalWrite(D3, LOW); // LED ausschalten
            delay(500);
            digitalWrite(D3, HIGH); // LED anschalten
            delay(500);
            digitalWrite(D3, LOW); // LED ausschalten
            break;
        case 'B':
            //vibrate right one-handed
            digitalWrite(D1, HIGH); // LED anschalten
            delay(500);
            digitalWrite(D1, LOW); // LED ausschalten
            delay(500);
            digitalWrite(D1, HIGH); // LED anschalten
            delay(500);
            digitalWrite(D1, LOW); // LED ausschalten
            break;
        case 'N':
            //vibrate left two-handed
            digitalWrite(D3, HIGH); // LED anschalten
            delay(500);
            digitalWrite(D3, LOW); // LED ausschalten
        case 'M':
            //vibrate right two-handed
            digitalWrite(D1, HIGH); // LED anschalten
            delay(500);
            digitalWrite(D1, LOW); // LED ausschalten
    }
}
