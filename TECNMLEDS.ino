#include <LedControl.h>

// A0 = 14, A1 = 15, A2 = 16
LedControl M(14, 15, 16, 1);

// ==== PINES DE LEDS (A3-A5) ====
int led1 = 17;  // A3
int led2 = 18;  // A4
int led3 = 19;  // A5

// ==== LETRAS EN MATRIZ 8x8 ====
// T
byte T_[8] = {
  B01111110, B00011000, B00011000, B00011000,
  B00011000, B00011000, B00000000, B00000000
};
// E
byte E_[8] = {
  B01111110, B01100000, B01111100, B01100000,
  B01100000, B01111110, B00000000, B00000000
};
// C
byte C_[8] = {
  B00111100, B01100010, B01100000, B01100000,
  B01100000, B01100010, B00111100, B00000000
};
// N
byte N_[8] = {
  B01100110, B01110110, B01111110, B01101110,
  B01100110, B01100110, B00000000, B00000000
};
// M
byte M_[8] = {
  B01100011, B01110111, B01111111, B01101011,
  B01100011, B01100011, B00000000, B00000000
};

// ===== EFECTO LED RUNNING + STROBO =====
void efectoLeds() {
  // Running 1 → 2 → 3
  digitalWrite(led1, HIGH); delay(150);
  digitalWrite(led1, LOW);

  digitalWrite(led2, HIGH); delay(150);
  digitalWrite(led2, LOW);

  digitalWrite(led3, HIGH); delay(150);
  digitalWrite(led3, LOW);

  // Strobo rápido
  for (int i = 0; i < 3; i++) {
    digitalWrite(led1, HIGH);
    digitalWrite(led2, HIGH);
    digitalWrite(led3, HIGH);
    delay(80);
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    delay(80);
  }
}

// ==== MOSTRAR LETRA ====
void mostrarLetra(byte L[]) {
  M.clearDisplay(0);

  for (int i = 0; i < 8; i++) {
    M.setRow(0, i, L[i]);
  }

  efectoLeds(); // aquí entra la animación
}

void setup() {
  M.shutdown(0, false);
  M.setIntensity(0, 8);
  M.clearDisplay(0);

  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
}

void loop() {
  mostrarLetra(T_);
  mostrarLetra(E_);
  mostrarLetra(C_);
  mostrarLetra(N_);
  mostrarLetra(M_);

  delay(1000);
}
