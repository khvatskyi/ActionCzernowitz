import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavigationBarComponent } from './components/navigation-bar/navigation-bar.component';
import { HomeContentComponent } from './components/home-content/home-content.component';
import { MainInfoComponent } from './components/home-content/main-info/main-info.component';
import { LastNewsComponent } from './components/home-content/last-news/last-news.component';
import { DirectionsComponent } from './components/home-content/directions/directions.component';
import { ActionAbbreviationComponent } from './components/home-content/action-abbreviation/action-abbreviation.component';
import { FooterComponent } from './components/footer/footer.component';
import { AboutUsContentComponent } from './components/about-us-content/about-us-content.component';
import { RouterModule } from '@angular/router';
import { NewsContentComponent } from './components/news-content/news-content.component';
import { MagazinesContentComponent } from './components/magazines-content/magazines-content.component';
import { ContactsContentComponent } from './components/contacts-content/contacts-content.component';
import { RulesContentComponent } from './components/rules-content/rules-content.component';
import { PrivacyContentComponent } from './components/privacy-content/privacy-content.component';
import { SearchContentComponent } from './components/search-content/search-content.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigationBarComponent,
    HomeContentComponent,
    MainInfoComponent,
    LastNewsComponent,
    DirectionsComponent,
    ActionAbbreviationComponent,
    FooterComponent,
    AboutUsContentComponent,
    NewsContentComponent,
    MagazinesContentComponent,
    ContactsContentComponent,
    RulesContentComponent,
    PrivacyContentComponent,
    SearchContentComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      {path: '', redirectTo: '/home', pathMatch: 'full'},
      {path: 'home', component: HomeContentComponent},
      {path: 'about-us', component: AboutUsContentComponent},
      {path: 'news', component: NewsContentComponent},
      {path: 'magazines', component: MagazinesContentComponent},
      {path: 'contacts', component: ContactsContentComponent},
      {path: 'rules', component: RulesContentComponent},
      {path: 'privacy', component: PrivacyContentComponent},
      {path: 'search', component: SearchContentComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
