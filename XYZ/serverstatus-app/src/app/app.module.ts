import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ServerHealthService } from './services/ServerHealthService';
import { HttpClientModule } from '@angular/common/http';
import { AppConfig } from './config/AppConfig';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [ ServerHealthService, AppConfig ],
  bootstrap: [AppComponent]
})
export class AppModule { }
