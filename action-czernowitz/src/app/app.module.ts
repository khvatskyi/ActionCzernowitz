import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavigationBarComponent } from './components/navigation-bar/navigation-bar.component';
import { HomeContentComponent } from './components/home-content/home-content.component';
import { MainInfoComponent } from './components/home-content/main-info/main-info.component';
import { LastNewsComponent } from './components/home-content/last-news/last-news.component';
import { DirectionsComponent } from './components/home-content/directions/directions.component';
import { ActionAbbreviationComponent } from './components/home-content/action-abbreviation/action-abbreviation.component';
import { ContactsComponent } from './components/home-content/contacts/contacts.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigationBarComponent,
    HomeContentComponent,
    MainInfoComponent,
    LastNewsComponent,
    DirectionsComponent,
    ActionAbbreviationComponent,
    ContactsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
