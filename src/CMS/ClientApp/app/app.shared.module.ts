import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { NavBarComponent } from './components/shared/navbar/navbar.component'
import { SidebarComponent } from './components/shared/sidebar/sidebar.component'
import { DashboardComponent } from './components/dashboard/dashboard.component'
import { UserProfileComponent } from './components/user-profile/user-profile.component'
import { HeroComponent } from './components/hero/hero.component'
import { ImageUploadModule } from "angular2-image-upload";


@NgModule({
    declarations: [ // which components to use for the main app modeul
        AppComponent,
        HomeComponent,
        NavBarComponent,
        SidebarComponent,
        DashboardComponent,
        UserProfileComponent,
        HeroComponent,
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ImageUploadModule.forRoot(),
        RouterModule.forRoot([
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', component: DashboardComponent },
            { path: 'home', component: HomeComponent },
            { path: 'profile', component: UserProfileComponent },
            { path: '**', redirectTo: 'dashboard' }
        ])
    ]
})
export class AppModuleShared {
}
