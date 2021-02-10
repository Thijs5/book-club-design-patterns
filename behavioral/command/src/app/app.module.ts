import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TelevisionComponent } from './components/television/television.component';
import { RemoteComponent } from './components/remote/remote.component';

@NgModule({
  declarations: [
    AppComponent,
    TelevisionComponent,
    RemoteComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
