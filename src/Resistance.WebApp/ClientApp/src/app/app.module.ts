import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MaterialModule } from '@angular/material';
import { FlexLayoutModule } from "@angular/flex-layout";

import { AppComponent } from './app.component';
import { GameCreatorComponent } from './game-creator/game-creator.component';
import { LoginModalComponent } from './login-modal/login-modal.component';
import { Auth } from './services/auth/auth.service';

@NgModule({
  declarations: [
    AppComponent,
    GameCreatorComponent,
    LoginModalComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    MaterialModule,
    FlexLayoutModule
  ],
  exports: [
    LoginModalComponent
  ],
  entryComponents: [
    LoginModalComponent
  ],
  providers: [
    Auth
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
