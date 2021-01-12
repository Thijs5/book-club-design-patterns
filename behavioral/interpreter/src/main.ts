import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));

if (!Array.prototype.lastIndexOf) {
  Array.prototype.lastIndexOf = function(elt /*, from*/) {
      let len = this.length;
      let from = Number(arguments[1]);

      if (isNaN(from)) {
        from = len - 1;
      } else {
        from = (from < 0)
        ? Math.ceil(from)
        : Math.floor(from);

        if (from < 0) {
        from += len;
        }

        else if (from >= len) {
        from = len - 1;
 }
      }

      for (; from > -1; from--) {
        if (from in this &&
        this[from] === elt) {
        return from;
        }
      }
      return -1;
  };
}
