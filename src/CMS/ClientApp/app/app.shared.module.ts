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
import { GalleryUploadComponent } from "./components/gallery-upload/gallery-upload.component";

import { HeroComponent } from './components/hero/hero.component'
import { ImageUploadModule } from "angular2-image-upload";
import { IntroComponent } from "./components/intro/intro.component";
import { FeatureComponent } from "./components/feature/feature.component";
import { FeaturesComponent } from "./components/features/features.component";
import { FeatureLargeComponent } from "./components/feature-large/feature-large.component";
import { BasicInfoComponent } from "./components/basic-info/basic-info.component";
import { InfoBlockComponent } from "./components/info-block/info-block.component";
import { AboutComponent } from "./components/about/about.component";
import { ServicesComponent } from "./components/services/services.component";
import { ServiceListComponent } from "./components/service-list/service-list.component";
import { SpecialiseComponent } from "./components/specialise/specialise.component";
import { WorkComponent } from "./components/work/work.component";
import { TestimonialsComponent } from "./components/testimonials/testimonials.component";

import { HomeService } from './services/home-service';

@NgModule({
    declarations: [ // which components to use for the main app modeul
        AppComponent,
        HomeComponent,
        NavBarComponent,
        SidebarComponent,
        DashboardComponent,
        UserProfileComponent,
        HeroComponent,
        GalleryUploadComponent,
        IntroComponent,
        FeatureComponent,
        FeatureLargeComponent,
        BasicInfoComponent,
        InfoBlockComponent,
        AboutComponent,
        ServicesComponent,
        ServiceListComponent,
        FeaturesComponent,
        SpecialiseComponent,
        WorkComponent,
        TestimonialsComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ImageUploadModule.forRoot(),
        RouterModule.forRoot([
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', component: DashboardComponent },
            { path: 'profile', component: UserProfileComponent },
            { path: 'home', component: HomeComponent },
            { path: 'about', component: AboutComponent },
            { path: 'services', component: ServicesComponent },
            { path: 'work', component: WorkComponent },
            { path: 'testimonials', component: TestimonialsComponent },
            { path: '**', redirectTo: 'dashboard' }
        ])
    ],
    providers: [
        HomeService
    ]
})
export class AppModuleShared {
}