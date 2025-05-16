const int buttonPin = A0;
bool pressed = false;

void setup() {
  pinMode(buttonPin, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  int buttonState = analogRead(buttonPin);

  if (buttonState < 100 && pressed == false) {
    Serial.println("JUMP");
    Serial.println(buttonState);
    pressed = true;

  }
  else {
    pressed = false;
  }

  delay(100);
}